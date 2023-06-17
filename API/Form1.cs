using HtmlAgilityPack;
namespace API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://thoitiet.vn/ho-chi-minh");
            var content = await response.Content.ReadAsStringAsync();

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(content);
            //<div class="precipitation" title="Lượng mưa">
               // < i class="bi bi-droplet"></i>
               // 63 %
           // </div>
            var titleNode = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='current-temperature']");
            if (titleNode != null)
            {
                ND.Text = titleNode.InnerHtml;
            }
            var titleNode1 = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='text-white op-8 fw-bold']");
            if (titleNode1 != null)
            {
                DA.Text = titleNode1.InnerHtml;
            }
            var titleNode2 = htmlDocument.DocumentNode.SelectSingleNode("//p[@class='mb-0']");
            if (titleNode2 != null)
            {
                PT.Text = titleNode2.InnerHtml;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
 }
