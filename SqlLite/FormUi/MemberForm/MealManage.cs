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
    public partial class MealManage : Form
    {
        List<Member> _memberList;
        MemberService _memberService;
        MealService _mealService;
        public MealManage()
        {
            InitializeComponent();

            _memberList = new List<Member>();
            _memberService = new MemberService();
            _mealService = new MealService();
        }

        private void MealManage_Load(object sender, EventArgs e)
        {
            LoadMember();
            deMealDate.EditValue = DateTime.Now;
            List<MealUnit> mealUnit = new List<MealUnit>() 
            { 
                new MealUnit() {Name=0.5m,Value= 0.5m}
                ,  new MealUnit() {Name=1,Value= 1}
                ,  new MealUnit() {Name=1.5m,Value= 1.5m}
                ,  new MealUnit() {Name=2m,Value= 2m}
                ,  new MealUnit() {Name=2.5m,Value= 2.5m}
                ,  new MealUnit() {Name=3m,Value= 3m}
                ,  new MealUnit() {Name=3.5m,Value= 3.5m}
                ,  new MealUnit() {Name=4m,Value= 4m}
                ,  new MealUnit() {Name=4.5m,Value= 4.5m}
            };

            mealUnitBindingSource.DataSource = mealUnit;
        }

        private void LoadMember()
        {
            _memberList = _memberService.LoadMember();
            if (_memberList != null && _memberList.Count > 0)
            {
                memberBindingSource.DataSource = _memberList;
                // gcMember.RefreshDataSource();
                //gcMember.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Member member = (Member)lueMember.GetSelectedDataRow();
            Meal meal = new Meal();
            meal.CreationDate = DateTime.Now;
            meal.MealDate = (DateTime)deMealDate.EditValue;
            meal.Date = meal.MealDate.Date.ToString();
            meal.Month = meal.MealDate.Month.ToString();
            meal.Year = meal.MealDate.Year.ToString();
            meal.MemberId = member.ID;
            //meal.MealDate =(DateTime) mealDate;
            var mealUnit = (MealUnit)lueMealUnit.GetSelectedDataRow();
            meal.MealUnit = mealUnit.Value;
            meal.IsBillGenerate = 0;
            _mealService.Create(meal);
        }
    }
}
