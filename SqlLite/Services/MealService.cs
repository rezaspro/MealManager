using SqlLite.Models.Entities;
using SqlLite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlLite.FormUi.MemberForm
{
    public class MealService
    {
        MealDao mealDao = new MealDao();

        public void Create(Meal meal)
        {
            mealDao.Create(meal);
        }
    }
}
