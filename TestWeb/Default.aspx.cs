using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string original_text = TextBox1.Text;
            string matchString = Regex.Match(original_text, "<img.+?src=[\"'](.+?)[\"'].+?>", RegexOptions.IgnoreCase).Groups[1].Value;
            Label1.Text = matchString;
            Label3.Text = original_text;
            Label2.Text = original_text.Replace(matchString, "https://www.markimicrowave.com/Assets/ProductImages/Mixers/Mixer_Block_Diagram.png");

            //string strRegex = @"(?<=src="").*?(?="")";
            //Regex srcRegex = new Regex(strRegex);
            //string strTargetString = TextBox1.Text;
            //string srcElement = srcRegex.Match(strTargetString).Value; // SRC
            //string imgRegex = @"<img.*?>";            
            //Label1.Text = srcElement;
            //Label3.Text = original_text;
            //Label2.Text = Regex.Replace(strTargetString, imgRegex, "http://localhost:59449/Images/Fish_images.jpg");
            //string.Format("< img src ={0}", "https://www.markimicrowave.com/Assets/ProductImages/Mixers/Mixer_Block_Diagram.png");
            //Label2.Text = Regex.Replace(strTargetString, imgRegex, string.Format("< img src ="+"{0}"+" />", "https://www.markimicrowave.com/Assets/ProductImages/Mixers/Mixer_Block_Diagram.png"));
        }
    }
}