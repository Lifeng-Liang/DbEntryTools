using System;
using System.Windows.Forms;
using System.Reflection;

namespace SqlQuerier
{
    partial class MyAbout : Form
    {
        public MyAbout()
        {
            InitializeComponent();

            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region 程序集属性访问器

        public string AssemblyTitle
        {
            get
            {
                // 获取此程序集上的所有 Title 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // 如果至少有一个 Title 属性
                if (attributes.Length > 0)
                {
                    // 请选择第一个属性
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // 如果该属性为非空字符串，则将其返回
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // 如果没有 Title 属性，或者 Title 属性为一个空字符串，则返回 .exe 的名称
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // 获取此程序集的所有 Description 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // 如果 Description 属性不存在，则返回一个空字符串
                if (attributes.Length == 0)
                    return "";
                // 如果有 Description 属性，则返回该属性的值
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // 获取此程序集上的所有 Product 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // 如果 Product 属性不存在，则返回一个空字符串
                if (attributes.Length == 0)
                    return "";
                // 如果有 Product 属性，则返回该属性的值
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // 获取此程序集上的所有 Copyright 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // 如果 Copyright 属性不存在，则返回一个空字符串
                if (attributes.Length == 0)
                    return "";
                // 如果有 Copyright 属性，则返回该属性的值
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // 获取此程序集上的所有 Company 属性
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // 如果 Company 属性不存在，则返回一个空字符串
                if (attributes.Length == 0)
                    return "";
                // 如果有 Company 属性，则返回该属性的值
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
