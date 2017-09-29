using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NGAtextEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TreeViewItem treeViewItem1 = new TreeViewItem();
            treeViewItem1.Header = "第一级";
            Outline.Items.Add(treeViewItem1);
            TreeViewItem treeViewItem2 = new TreeViewItem();
            treeViewItem2.Header = "第二级";
            treeViewItem1.Items.Add(treeViewItem2);
            TreeViewItem treeViewItem3 = new TreeViewItem();
            treeViewItem3.Header = "第三级";
            treeViewItem2.Items.Add(treeViewItem3);
        }
    }
}
