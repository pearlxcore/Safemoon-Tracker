//jangan la baca.. malu la code bersepah. xD

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Safemoon_Stats
{
    public partial class Form1 : DarkUI.Forms.DarkForm
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

      
        private string GetCertainDecimal(string value, int length)
        {
            value = value.Substring(0, value.Length - length);
            return value;
        }

        private string FormatValue(string value)
        {
            string val_ = "";
            if (value != string.Empty)
            {
                double val = Convert.ToDouble(value);
                val_ = val.ToString("#,#", CultureInfo.InvariantCulture);
            }
            else
                val_ = "";
            return val_;

        }

        private dynamic GetDynamicJson(string url)
        {
            dynamic a = null;
            //// WebClient client = new WebClient();
            ////Stream stream_ = client.OpenRead(url);
            ////StreamReader reader_ = new StreamReader(stream_);
            ////string content = reader_.ReadToEnd();
            ////a = JsonConvert.DeserializeObject(content);

            Task.Run(async () =>
            {
                using (HttpClient client = new HttpClient())
                {

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    a = JsonConvert.DeserializeObject(responseBody);
                }
            }).Wait();
            return a;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Custom_font();
            label3.Font = new Font(font_Insomnia, 25, FontStyle.Regular);

            //foreach (FlatTabControl.FlatTabControl c in this.Controls)
            //{
            //    c.Font = new Font(font_Insomnia, 9, FontStyle.Regular);
            //}
            GetIntervalPriceVolumeCap();
            var currentVersion = new Version(Assembly.GetExecutingAssembly().GetName().Version.ToString());
            this.Text += " " + currentVersion;
        }

        private void GetIntervalPriceVolumeCap()
        {
            new Thread(() =>
            { }).Start();

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */

                while (true)
                {
                    if (Var.pullWallet == false)
                    {
                        try
                        {
                            //price, trading volume, market cap (nomics)
                            string Volume = "";
                            string Marketcap = "";
                            string VolumeChangePercantage = "";
                            string MarketcapChangePercantage = "";
                            string PricecapChangePercantage = "";
                            string price = "";

                            dynamic volumeMarketcap = GetDynamicJson("https://api.nomics.com/v1/currencies/ticker?key=4e0c191824839cb58cd7de67ccff8cddee0d6f45&ids=SAFEMOON");
                            foreach (var item in volumeMarketcap)
                            {
                                price = GetCertainDecimal(item.price.ToString(), 5);

                                Marketcap = item.market_cap.ToString();
                                Volume = item["1d"].volume;
                                VolumeChangePercantage = item["1d"].volume_change_pct;
                                MarketcapChangePercantage = item["1d"].market_cap_change_pct;
                                PricecapChangePercantage = item["1d"].price_change_pct;

                            }

                            var Marketcap_ = Convert.ToDouble(Marketcap).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
                            var Volume_ = Convert.ToDouble(Volume).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));

                            PricecapChangePercantage = (Convert.ToDouble(PricecapChangePercantage) * 100).ToString();
                            MarketcapChangePercantage = (Convert.ToDouble(MarketcapChangePercantage) * 100).ToString();
                            VolumeChangePercantage = (Convert.ToDouble(VolumeChangePercantage) * 100).ToString();

                            if (PricecapChangePercantage.Contains("-"))
                                labelPrice.ForeColor = Color.Red;
                            else
                            {
                                labelPrice.ForeColor = Color.Green;
                                PricecapChangePercantage = PricecapChangePercantage.Insert(0, "+");
                            }

                            if (MarketcapChangePercantage.Contains("-"))
                                labelMarketcap.ForeColor = Color.Red;
                            else
                            {
                                labelMarketcap.ForeColor = Color.Green;
                                MarketcapChangePercantage = MarketcapChangePercantage.Insert(0, "+");
                            }
                            if (VolumeChangePercantage.Contains("-"))
                                labelVolume.ForeColor = Color.Red;
                            else
                            {
                                labelVolume.ForeColor = Color.Green;
                                VolumeChangePercantage = VolumeChangePercantage.Insert(0, "+");
                            }
                            labelPrice.Text = ("$" + price + " USD (" + PricecapChangePercantage + "%)");
                            labelMarketcap.Text = Marketcap_ + " USD (" + MarketcapChangePercantage + "%)";
                            labelVolume.Text = Volume_ + " USD (" + VolumeChangePercantage + "%)";
                            Var.Price = price;
                            Var.Volume = FormatValue(Volume);

                        }
                        catch { }
                    }

                    Thread.Sleep(10000);
                }

            }).Start();
        }

        private void Run()
        {
            new Thread(() =>
            {
                try
                {
                    btnPull.Enabled = false;
                    btnPull.Text = "Retrieving data..";
                    Var.pullWallet = true;

                    if (tbAddress.Text == string.Empty)
                    {
                        MessageBox.Show("Specify wallet address", "Error");
                        btnPull.Enabled = true;
                        return;
                    }
                    //check auth status
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Time");
                    dt.Columns.Add("Hash");
                    dt.Columns.Add("Transaction");

                    dt.Columns.Add("From");
                    dt.Columns.Add("To");

                    dt.Columns.Add("Safemoon value");
                    dt.Columns.Add("Estimate Safemoon price at time of Txn");
                    dt.Columns.Add("Estimate total price at time of Txn");

                    long buy = 0;
                    long sell = 0;
                    string content = "";
                    string address = tbAddress.Text;
                    string url = "https://api.bscscan.com/api?module=account&action=tokentx&contractaddress=0x8076c74c5e3f5852037f31ff0093eeb8c8add8d3&address=" + address + "&page=1&offset=100&sort=asc&apikey=CKEAKUG2DTZ4N7ZFVJYM2Y9DJM7FX365WW";
                    string url_ = "https://api.bscscan.com/api?module=account&action=tokentx&contractaddress=0x8076c74c5e3f5852037f31ff0093eeb8c8add8d3&address=" + address + "&page=1&offset=100&sort=asc&apikey=CKEAKUG2DTZ4N7ZFVJYM2Y9DJM7FX365WW";


                    dynamic dynJson = GetDynamicJson(url_);
                    if (dynJson.result.ToString() == "Error! Invalid address format")
                    {
                        MessageBox.Show("Invalid address format", "Error");
                        btnPull.Enabled = true;
                        return;
                    }

                    int count = dynJson.result.Count;

                    if (count == 0)
                    {
                        MessageBox.Show("Unknown address", "Error");
                        btnPull.Enabled = true;
                        return;
                    }


                    foreach (var node in dynJson.result)
                    {
                        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(node.timeStamp.ToString()));
                        var dateTime = dateTimeOffset.DateTime;
                        //DateTimeOffset dateTimeOffset2 = DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(node.timeStamp.ToString()));
                        string value = "";
                        string transactionType = "";
                        value = node.value.ToString();

                        string value_final = GetCertainDecimal(value, 9);

                        string from = "";
                        string to = "";



                        if (node.from == "0x9adc6fb78cefa07e13e9294f150c1e8c1dd566c0")
                            from = "Pancake Swap";
                        else if (node.from == "0xff3dd404afba451328de089424c74685bf0a43c9")
                            from = "Pancake Swap (V2)";
                        else if ((node.from).ToString().Equals(address, StringComparison.InvariantCultureIgnoreCase))
                            from = "Wallet";
                        else
                            from = node.from;

                        if (node.to == "0x9adc6fb78cefa07e13e9294f150c1e8c1dd566c0")
                            to = "Pancake Swap";
                        else if (node.to == "0xff3dd404afba451328de089424c74685bf0a43c9")
                            to = "Pancake Swap (V2)";
                        else if ((node.to).ToString().Equals(address, StringComparison.InvariantCultureIgnoreCase))
                            to = "Wallet";
                        else
                            to = node.to;

                        //buy
                        if (node.from != address)
                        {
                            long buy_ = Convert.ToInt64(value_final);
                            buy = buy + buy_;


                        }
                        else if (node.from == address)
                        {
                            long sell_ = Convert.ToInt64(value_final);
                            sell = sell + sell_;
                        }

                        if (node.from != address)
                            transactionType = "Received";
                        else
                            transactionType = "Sent";

                        string date = JsonConvert.SerializeObject(dateTime).Replace("\"", "");
                        date = date.Substring(0, 10);
                        string price_ = "";
                        price_ = GetPrice(date);
                        double TotalPrice = Convert.ToDouble(price_) * Convert.ToDouble(value_final);
                        string TotalPrice_ = TotalPrice.ToString();
                        TotalPrice_ = TotalPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));/*String.Format("{0:0.00}", TotalPrice);  */


                        dt.Rows.Add(dateTimeOffset.ToString().Replace(" +00:00", ""), node.hash, transactionType, from, to, FormatValue(value_final) + " SAFEMOON", price_ + " USD", TotalPrice_ + " USD");
                    }
                    if (buy == 0)
                        labelBuys.Text = "0 SAFEMOON";
                    else
                        labelBuys.Text = FormatValue(buy.ToString()) + " SAFEMOON";

                    if (sell == 0)
                        labelSells.Text = "0 SAFEMOON";
                    else
                        labelSells.Text = FormatValue(sell.ToString()) + " SAFEMOON";



                    //balance
                    dynamic json = GetDynamicJson("https://api.bscscan.com/api?module=account&action=tokenbalance&contractaddress=0x8076c74c5e3f5852037f31ff0093eeb8c8add8d3&address=" + address + "&tag=latest&apikey=CKEAKUG2DTZ4N7ZFVJYM2Y9DJM7FX365WW");
                    string balance = json.result;
                    balance = GetCertainDecimal(balance, 9);

                    string price = "";
                    price = GetPriceVolumeMarketcap();


                    var reflection = (Convert.ToDouble(balance) + Convert.ToDouble(sell)) - Convert.ToDouble(buy);
                    var reflectionPrice = Convert.ToDouble(price) * (Convert.ToDouble(balance) - Convert.ToDouble(buy));
                    string reflectionPrice_ = reflectionPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
                    var balancePrice = Convert.ToDouble(price) * (Convert.ToDouble(balance));
                    string currentBalancePrice = balancePrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));


                    labelCurrentBalance.Text = (FormatValue(balance) + " SAFEMOON (" + currentBalancePrice + " USD)").Replace("-", "");
                    labelReflection.Text = (FormatValue(reflection.ToString()) + " SAFEMOON (" + reflectionPrice_.Replace("(","").Replace(")", "") + " USD)").Replace("-", "");

                    darkDataGridView1.DataSource = dt;
                    Var.pullWallet = false;
                    btnPull.Enabled = true;
                    btnPull.Text = "Pull Wallet Data";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnPull.Enabled = true;
                    return;
                }

            }).Start();
            //var bw = new BackgroundWorker();
            //bw.DoWork += delegate {


            //};
            //bw.RunWorkerCompleted += delegate {
            //};
            //bw.RunWorkerAsync();
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            Run();
        }

        private string GetPrice(string date)
        {
            string url = "https://api.nomics.com/v1/currencies/sparkline?key=4e0c191824839cb58cd7de67ccff8cddee0d6f45&ids=SAFEMOON&start=" + date + "T00%3A00%3A00Z&end=" + date + "T00%3A00%3A00Z";
            dynamic json = GetDynamicJson(url);
            string prices = "";

            foreach (var items in json)
            {
                
                //MessageBox.Show(items.prices.ToString());
                foreach(var price in items.prices)
                {
                    prices = price.ToString();
                    break;
                }
            }
            return prices;
        }


        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily font_Insomnia;

        private void Custom_font()
        {
            PrivateFontCollection new_Font = new PrivateFontCollection();

            int long_font = Properties.Resources.ethnocentric_rg.Length;

            byte[] fontdata = Properties.Resources.ethnocentric_rg;

            IntPtr replace = Marshal.AllocCoTaskMem(long_font);

            Marshal.Copy(fontdata, 0, replace, long_font);

            uint cFonts = 0;

            AddFontMemResourceEx(replace, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);

            new_Font.AddMemoryFont(replace, long_font);

            Marshal.FreeCoTaskMem(replace);

            font_Insomnia = new_Font.Families[0];
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {

            GetPriceVolumeMarketcap();



        }

        private string GetPriceVolumeMarketcap()
        {
            //price, trading volume, market cap (nomics)
            string Volume = "";
            string Marketcap = "";
            string VolumeChangePercantage = "";
            string MarketcapChangePercantage = "";
            string PricecapChangePercantage = "";
            string price = "";

            dynamic volumeMarketcap = GetDynamicJson("https://api.nomics.com/v1/currencies/ticker?key=4e0c191824839cb58cd7de67ccff8cddee0d6f45&ids=SAFEMOON");
            foreach (var item in volumeMarketcap)
            {
                price = GetCertainDecimal(item.price.ToString(), 5);

                Marketcap = item.market_cap.ToString();
                Volume = item["1d"].volume;
                VolumeChangePercantage = item["1d"].volume_change_pct;
                MarketcapChangePercantage = item["1d"].market_cap_change_pct;
                PricecapChangePercantage = item["1d"].price_change_pct;

            }

            var Marketcap_ = Convert.ToDouble(Marketcap).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            var Volume_ = Convert.ToDouble(Volume).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));

            PricecapChangePercantage = (Convert.ToDouble(PricecapChangePercantage) * 100).ToString();
            MarketcapChangePercantage = (Convert.ToDouble(MarketcapChangePercantage) * 100).ToString();
            VolumeChangePercantage = (Convert.ToDouble(VolumeChangePercantage) * 100).ToString();

            if (PricecapChangePercantage.Contains("-"))
                labelPrice.ForeColor = Color.Red;
            else
            {
                labelPrice.ForeColor = Color.Green;
                PricecapChangePercantage = PricecapChangePercantage.Insert(0, "+");
            }

            if (MarketcapChangePercantage.Contains("-"))
                labelMarketcap.ForeColor = Color.Red;
            else
            {
                labelMarketcap.ForeColor = Color.Green;
                MarketcapChangePercantage = MarketcapChangePercantage.Insert(0, "+");
            }
            if (VolumeChangePercantage.Contains("-"))
                labelVolume.ForeColor = Color.Red;
            else
            {
                labelVolume.ForeColor = Color.Green;
                VolumeChangePercantage = VolumeChangePercantage.Insert(0, "+");
            }
            labelPrice.Text = ("$" + price + " USD (" + PricecapChangePercantage + "%)");
            labelMarketcap.Text = Marketcap_ + " USD (" + MarketcapChangePercantage + "%)";
            labelVolume.Text = Volume_ + " USD (" + VolumeChangePercantage + "%)";
            //tbVolume.Text = FormatValue(Volume); ;
            //tbPrice.Text = price;

            return price;
        }

        private void CalculateReflection()
        {
            if (tbTotalSafemoon.Text == string.Empty || tbPrice.Text == string.Empty || tbVolume.Text == string.Empty)
            {
                return;
            }
          

            UInt64 TotalSafemoon = 0;
            double price = 0;
            UInt64 volume = 0;
            BigInteger totalSupply = 20000000000000000;
            double safemoonReflection = 0;
            BigInteger MultipliedVolumeSafemoon = 0;
            double MultipliedVolumeSafemoon_ = 0;
            double reflections_ = 0;
            price = Convert.ToDouble(tbPrice.Text);

            MultipliedVolumeSafemoon = BigInteger.Multiply(BigInteger.Parse(tbVolume.Text.Replace(",", "")),
                                 BigInteger.Parse(tbTotalSafemoon.Text.Replace(",", "")));

            MultipliedVolumeSafemoon_ = (double)MultipliedVolumeSafemoon;
            Var.reflections = MultipliedVolumeSafemoon_ / 20000000000000000;


            reflections_ = Var.reflections * Convert.ToDouble(darkNumericUpDown1.Value.ToString());

            safemoonReflection = (double)reflections_ / price;


            tbDailyReflection.Text = reflections_.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")) + " (" + FormatValue(safemoonReflection.ToString()) + " SAFEMOON)";
        }

        private void darkButton5_Click(object sender, EventArgs e)
        {
            if(tbTotalSafemoon.Text == string.Empty)
            {
                MessageBox.Show("Specify safemoon token", "error");
                return;
            }
            if (tbPrice.Text == string.Empty)
            {
                MessageBox.Show("Specify price", "error");
                return;
            }
            if (tbVolume.Text == string.Empty)
            {
                MessageBox.Show("Specify volume", "error");
                return;
            }
            var bw = new BackgroundWorker();
            bw.DoWork += delegate {

                CalculateReflection();
            };
            bw.RunWorkerCompleted += delegate {
                // do something with the results.
            };
            bw.RunWorkerAsync();
        }

        private void tbTotalSafemoon_Leave(object sender, EventArgs e)
        {
            tbTotalSafemoon.Text = FormatValue(tbTotalSafemoon.Text);
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {

        }

        private void tbVolume_Leave(object sender, EventArgs e)
        {
            tbVolume.Text = FormatValue(tbVolume.Text);

        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text == string.Empty)
            {
                MessageBox.Show("Specify wallet address", "Error");
                return;
            }            //balance
           

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */

                try
                {
                    dynamic json = GetDynamicJson("https://api.bscscan.com/api?module=account&action=tokenbalance&contractaddress=0x8076c74c5e3f5852037f31ff0093eeb8c8add8d3&address=" + tbAddress.Text + "&tag=latest&apikey=CKEAKUG2DTZ4N7ZFVJYM2Y9DJM7FX365WW");
                    string balance = json.result;
                    balance = GetCertainDecimal(balance, 9);
                    tbTotalSafemoon.Text = FormatValue(balance);

                }
                catch { }

            }).Start();
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            tbPrice.Text = Var.Price;
            tbVolume.Text = Var.Volume;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbAmountSafemoon_TextChanged(object sender, EventArgs e)
        {
            if (tbAmountSafemoon.Text != string.Empty)
            {
                tbAmountSafemoon.Text = FormatValue(tbAmountSafemoon.Text);
                tbPriceInUsd.TextChanged -= tbPriceInUsd_TextChanged;

                double safemoon = Convert.ToDouble(tbAmountSafemoon.Text.Replace(",", ""));
                double priceInUSD = Convert.ToDouble(Var.Price) * safemoon;
                tbPriceInUsd.Text = Convert.ToDouble(Convert.ToDecimal(priceInUSD).ToString()).ToString("C2", CultureInfo.CreateSpecificCulture("en-US")).Replace("$","");

                tbPriceInUsd.TextChanged += tbPriceInUsd_TextChanged;
                tbAmountSafemoon.SelectionStart = tbAmountSafemoon.Text.Length;
                tbAmountSafemoon.SelectionLength = 0;
            }
            else if(tbAmountSafemoon.Text == "")
                tbPriceInUsd.Text = "";
               
        }

        private void tbPriceInUsd_TextChanged(object sender, EventArgs e)
        {
            if (tbPriceInUsd.Text != string.Empty)
            {
                tbPriceInUsd.Text = FormatValue(tbPriceInUsd.Text);
                tbAmountSafemoon.TextChanged -= tbAmountSafemoon_TextChanged;

                double price = Convert.ToDouble(tbPriceInUsd.Text.Replace(",", ""));
                double amountSafemoon = price / Convert.ToDouble(Var.Price);
                tbAmountSafemoon.Text = FormatValue(amountSafemoon.ToString());

                tbAmountSafemoon.TextChanged += tbAmountSafemoon_TextChanged;
                tbPriceInUsd.SelectionStart = tbPriceInUsd.Text.Length;
                tbPriceInUsd.SelectionLength = 0;
            }
            else if (tbPriceInUsd.Text == "")
                tbAmountSafemoon.Text = "";

        }

        private void tbTotalSafemoon_TextChanged(object sender, EventArgs e)
        {
            if (tbTotalSafemoon.Text != string.Empty)
            {
                tbTotalSafemoon.Text = FormatValue(tbTotalSafemoon.Text);

                tbPrice.TextChanged -= tbPriceInUsd_TextChanged;
                tbVolume.TextChanged -= tbVolume_TextChanged;

                CalculateReflection();

                tbPrice.TextChanged += tbPriceInUsd_TextChanged;
                tbVolume.TextChanged += tbVolume_TextChanged;

                tbTotalSafemoon.SelectionStart = tbTotalSafemoon.Text.Length;
                tbTotalSafemoon.SelectionLength = 0;
            }
            else 
                tbDailyReflection.Text = "";


        }

        private void tbVolume_TextChanged(object sender, EventArgs e)
        {
            if (tbVolume.Text != string.Empty)
            {
                tbVolume.Text = FormatValue(tbVolume.Text);

                tbTotalSafemoon.TextChanged -= tbTotalSafemoon_TextChanged;
                tbPrice.TextChanged -= tbPrice_TextChanged;

                CalculateReflection();

                tbTotalSafemoon.TextChanged += tbTotalSafemoon_TextChanged;
                tbPrice.TextChanged += tbPrice_TextChanged;

                tbVolume.SelectionStart = tbVolume.Text.Length;
                tbVolume.SelectionLength = 0;
            }
            else
                tbDailyReflection.Text = "";


        }

        private void tbPriceInUsd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbTotalSafemoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkDataGridView1.SelectedCells.Count > 0)
            {
                string url = "";
                int selectedrowindex = darkDataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = darkDataGridView1.Rows[selectedrowindex];
                Var.TxHash = Convert.ToString(selectedRow.Cells[1].Value);
                url = "https://bscscan.com/tx/" + Var.TxHash;
                //System.Diagnostics.Process.Start(url);
                System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                //var info = new ProcessStartInfo(url);
                //Process.Start(info);
            }

            //if (darkDataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
            //{
               

            //    try
            //    {
            //        string url = "";
            //        foreach (DataGridViewCell cell in darkDataGridView1.SelectedCells)
            //        {
            //            int selectedrowindex = cell.RowIndex;
            //            DataGridViewRow selectedRow = darkDataGridView1.Rows[selectedrowindex];
            //            Var.TxHash = Convert.ToString(selectedRow.Cells[1].Value);
            //            url = "https://bscscan.com/tx/" + Var.TxHash;

            //        }

            //        System.Diagnostics.Process.Start(url);

            //    }
            //    catch (System.Runtime.InteropServices.ExternalException)
            //    {

            //        MessageBox.Show("The Clipboard could not be accessed.", "Eroor");
            //    }
            //}
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkDataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    string url = "";
                    int selectedrowindex = darkDataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = darkDataGridView1.Rows[selectedrowindex];
                    Var.TxHash = Convert.ToString(selectedRow.Cells[1].Value);
                    //url = "https://bscscan.com/tx/" + Var.TxHash;
                    ////System.Diagnostics.Process.Start(url);
                    //System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                    //var info = new ProcessStartInfo(url);
                    //Process.Start(info);
                    MessageBox.Show("Transaction hash copied to clipboard", "Info");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
               
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if(tbPrice.Text != string.Empty)
            {

                tbTotalSafemoon.TextChanged -= tbTotalSafemoon_TextChanged;
                tbVolume.TextChanged -= tbVolume_TextChanged;

                CalculateReflection();

                tbTotalSafemoon.TextChanged += tbTotalSafemoon_TextChanged;
                tbVolume.TextChanged += tbVolume_TextChanged;

                tbPrice.SelectionStart = tbPrice.Text.Length;
                tbPrice.SelectionLength = 0;
            }
            else
                tbDailyReflection.Text = "";
        }

        private void darkNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (tbTotalSafemoon.Text == string.Empty || tbPrice.Text == string.Empty || tbVolume.Text == string.Empty)
            {
                return;
            }

            double reflections_ = 0;
            double safemoonReflection = 0;
            double price = Convert.ToDouble(tbPrice.Text);

            reflections_ = Var.reflections * Convert.ToDouble(darkNumericUpDown1.Value.ToString());

            safemoonReflection = (double)reflections_ / price;


            tbDailyReflection.Text = reflections_.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")) + " (" + FormatValue(safemoonReflection.ToString()) + " SAFEMOON)";
        }
    }

    public class vars
    {
        private static string timestamp_;
        public static string timestamp
        {
            get { return timestamp_; }
            set { timestamp_ = value; }
        }
    }
}
