using SqlLite.Models.Entities;
using SqlLite.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlLite.FormUi.MemberForm
{
    public partial class MemberForm : Form
    {
        Member _member;
        List<Member> _memberList;
        MemberService _memberService;
        public MemberForm()
        {
            InitializeComponent();

            _member = new Member();
            _memberList = new List<Member>();
            _memberService = new MemberService();

            memberEntityBindingSource.DataSource = _member;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            var m = DateTime.Now.ToString("MMM");
            LoadMember();

        }

        private void LoadMember()
        {
            _memberList = _memberService.LoadMember();
            if (_memberList != null && _memberList.Count > 0)
            {
                memberBindingSource.DataSource = _memberList;
                gcMember.RefreshDataSource();
                gcMember.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.BackColor = SystemColors.Window;
                if(txtName.Text.Trim() == "")
                {
                    txtName.BackColor = Color.Cornsilk;
                    txtName.Focus();
                    return;
                }
                _memberService.Create(_member);
            }
            catch (Exception)
            {

                throw;
            }

            LoadMember();
        }
    }
}
