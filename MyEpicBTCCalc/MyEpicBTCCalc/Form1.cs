using System.Net;
using Newtonsoft.Json;

namespace MyEpicBTCCalc
{
    public partial class bitcoinAmountInput : Form
    {
        public bitcoinAmountInput()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bitcoinResultLable_Click(object sender, EventArgs e)
        {

        }
        public static BitcoinRates BitcoinRates()
        {
            string URL = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR&apply_mapping=true&api_key=d02697f9b2d493b2763467f1defa2dbd4f3a7e45525d01fefe3542c99319f049";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates newbitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                newbitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return newbitcoin;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (
                    (currencySelector.SelectedItem.ToString() != "USD" &&
                    currencySelector.SelectedItem.ToString() != "EUR")
                    || currencySelector.SelectedItem == null
                    )
                {
                    MessageBox.Show("Error", "VALUUTA ON VALIMATA");
                }
                else if (currencySelector.SelectedItem.ToString() == "USD")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(textBox1.Text) *
                        newRate.Data.BTCUSD.VALUE);
                    bitcoinResultLable.Text = result.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tekkis viga, vea detailide: {ex.Message}", $"{ex}");
            }
        }
    }
}
