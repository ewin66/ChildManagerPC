﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChildManager.Model;
using ChildManager.Model.ChildBaseInfo;
using ChildManager.BLL.ChildBaseInfo;

namespace ChildManager.UI
{
    public partial class Panel_gaowei_zhuanan_add : Form
    {
        private Panel_gaowei_zhuanan _gaoweizhuananpanel;
        private ChildGaoweigeanRecordBll gaoweirecordbll = new ChildGaoweigeanRecordBll();
        private ChildCheckObj _checkobj;
        public Panel_gaowei_zhuanan_add(Panel_gaowei_zhuanan gaoweizhuananpanel,ChildCheckObj checkobj)
        {
            InitializeComponent();

            _gaoweizhuananpanel = gaoweizhuananpanel;
            _checkobj = checkobj;
        }


        private void Paneltsb__gaowei_zhuanan_add_Load(object sender, EventArgs e)
        {
            textBoxX4.Text = _checkobj.CheckDay;
            textBoxX5.Text = _checkobj.CheckAge;
            textBoxX8.Text = _checkobj.DoctorName;
            textBoxX12.Text = _checkobj.gaoweirecordobj.pingufangfa;
            textBoxX1.Text = _checkobj.gaoweirecordobj.pingujieguo;
            textBoxX2.Text = _checkobj.gaoweirecordobj.zhidao;
            textBoxX3.Text = _checkobj.gaoweirecordobj.chuli;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            ChildGaoweigeanRecordObj gaoweirecordobj = getgaoweirecordObj();
            if (gaoweirecordbll.saveGaoweigeanrecord(gaoweirecordobj))
            {
                MessageBox.Show("保存成功！");
                this.Close();
                _gaoweizhuananpanel.refreshRecordList();
            }
            else
            {
                MessageBox.Show("保存失败！请联系管理员");
            }
        }

        private ChildGaoweigeanRecordObj getgaoweirecordObj()
        {
            ChildGaoweigeanRecordObj gaoweirecordobj = new ChildGaoweigeanRecordObj();
            gaoweirecordobj.id = _checkobj.gaoweirecordobj.id;
            gaoweirecordobj.checkid = _checkobj.Id;
            gaoweirecordobj.childId = _checkobj.ChildId;
            gaoweirecordobj.pingufangfa = textBoxX12.Text;
            gaoweirecordobj.pingujieguo = textBoxX1.Text;
            gaoweirecordobj.zhidao = textBoxX2.Text;
            gaoweirecordobj.chuli = textBoxX3.Text;
            return gaoweirecordobj;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
