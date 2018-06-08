using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoContent
{
    public partial class ContentAuto : Form
    {
        public ContentAuto()
        {
            InitializeComponent();
        }

        private void ContentAuto_Load(object sender, EventArgs e)
        {

        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            ContentHandle handle = new ContentHandle();
            string url = txtUrl.Text.Trim();
            string html = handle.ClearTag(url);
            NSoup.Nodes.Element list = handle.BodyElement(html);
            string  content = handle.GenerateElement(list);
            webContent.DocumentText = content;
        }
    }
}
