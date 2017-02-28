using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;
using System.Collections.Generic;
using WpfApplication3.ViewModel;

namespace WpfApplication3
{
    /// <summary>
    /// 客户列表详情
    /// </summary>
    public class KeHuShowListItem
    {
        //客户ID
        public int ID { get; set; }
        //客户姓名
        public string UserName { get; set; }
        //客户性别(先生/女士)
        public string XingBie { get; set; }
        //已弃用
        public string DianHua { get; set; }
        //已弃用
        public string YiXiang { get; set; }
        //订单状态说明
        public string MaiFangRunning { get; set; }
        //是否显示经点
        public bool HongDian { get; set; }
        //电话列表
        public List<DianHuaModel> DianHuaList { get; set; }
        //新房是否已报备(报备新房用这个，)
        public bool LouPanBaoBei { get; set; }
        //抵帐房是否已报备
        public bool DiZhangFangBaoBei { get; set; }
        //装修是否已报备
        public bool ZhuangXiuGongShiBaoBei { get; set; }
        //家政是否已报备
        public bool JiaZhengGongShiBaoBei { get; set; }
        //金融是否已报备
        public bool JinRongTypeBaoBei { get; set; }
    }
    /// <summary>
    /// 电话列表详细
    /// </summary>
    public class DianHuaModel
    {
        //客户电话ID
        public int ID { get; set; }
        //客户电话
        public string DianHua { get; set; }
        public string Remark { get; set; }
        public bool IsMoRen { get; set; }
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Messenger.Default.Register<string>(this, "ShowHelpView", ShowHelpView);
            //卸载当前(this)对象注册的所有MVVMLight消息
            Unloaded += (sender, e) => Messenger.Default.Unregister<string>(this, "ShowHelpView");


            var dianhualist = new List<DianHuaModel>();
            dianhualist.Add(new DianHuaModel { ID = 1, DianHua = "13840056621" });
            dianhualist.Add(new DianHuaModel { ID = 1, DianHua = "13840056622" });
            dianhualist.Add(new DianHuaModel { ID = 1, DianHua = "13840056623" });
            dianhualist.Add(new DianHuaModel { ID = 1, DianHua = "13840056624" });

            var list = new List<KeHuShowListItem>();
            list.Add(new KeHuShowListItem() { UserName = "2222", DianHuaList = dianhualist });
            list.Add(new KeHuShowListItem() { UserName = "3333", DianHuaList = dianhualist });
            list.Add(new KeHuShowListItem() { UserName = "4444", DianHuaList = dianhualist });
            listView.ItemsSource = list;
        }

        void ShowHelpView(string msg)
        {
            var t = new HelpWindow();

            var vm = ServiceLocator.Current.GetInstance<HelpViewModel>();
            vm.Info = msg;
            t.Show();
        }
    }
}
