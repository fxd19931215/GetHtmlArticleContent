using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NSoup.Nodes;
using NSoup.Select;
namespace AutoContent
{
   public class ContentHandle
    {

        /// <summary>
        /////去除内容注释，javascript
        /// </summary>
        /// <param name="url">需要处理的url</param>
        /// <returns>返回的html对象</returns>
        public string  ClearTag(string url)
        {
            string html = Common.Html.HtmlHelper.GetHtml(url, "", "", false, false);
            string htmlcode = Regex.Replace(html,"< !--(?:[\\s\\S] *?)-- >", "", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            htmlcode=Regex.Replace(htmlcode,"<script[\\s\\S].*?</script>", "", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            return htmlcode;
        }



        /// <summary>
        /////获取body中文本长度最长的一个html文档对象
        /// </summary>
        /// <param name="html">需要处理的html</param>
        /// <returns></returns>
        public Element BodyElement(string html)
        {
            Document doc = NSoup.NSoupClient.Parse(html);
            Element eleBody = doc.GetElementsByTag("body")[0];
            Elements notes = eleBody.Children;
            ArrayList textlist = new ArrayList();
            if (notes.Count > 3)
            {
                notes.Last().Remove();
            }
            string tempHtml = "";
            Element ele=null;
            foreach(Element node in notes)
            {
                string text = node.Text();
                if (text.Length > tempHtml.Length)
                {
                    tempHtml = text;
                    ele = node;
                }

                textlist.Add(text);

            }
            return ele ;

        }



        /// <summary>
        /////获取最大文本长度的文档
        /// </summary>
        /// <param name="ele">需要获取最大文档的html文档</param>
        /// <returns>返回具有最大长度字符的对象</returns>
        public Element GetMaxTxtEle(Element ele)
        {
            Elements eles = ele.Children;
            string temp = "";
            Element maxele = null;
            foreach (Element element in eles)
            {
                string txt = element.Text();
                if (txt.Length >temp.Length)
                {
                    temp = txt;
                    maxele = element;
                }
            }

            return maxele;
        }


        /// <summary>
        ///用递归获取正确格式的内容
        /// </summary>
        /// <param name="max">最大文档对象</param>
        /// <returns>返回正确的文档内容</returns>
        public string GenerateElement(Element max)
        {
            Element maxEle = GetMaxTxtEle(max);
            Elements A_ele = maxEle.GetElementsByTag("a");
            Elements img_ele = maxEle.GetElementsByTag("img");
            int allcount = A_ele.Count;
            if (allcount >3)
            {
              return GenerateElement(maxEle);
            }
            else
            {
                return maxEle.Html();
            }

        }



    }
}
