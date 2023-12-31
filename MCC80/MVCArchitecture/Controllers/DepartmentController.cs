﻿using MVCArchitecture.Models;
using MVCArchitecture.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Controllers
{
    public class DepartmentController
    {
        private Department _departmentModel;
        private VDepartment _departmentView;

        public DepartmentController(Department departmentModel, VDepartment departmentView)
        {
            _departmentModel = departmentModel;
            _departmentView = departmentView;
        }

        public void GetAll()
        {
            var result = _departmentModel.GetAll();
            if (result.Count is 0)
            {
                _departmentView.DataEmpty();
            }
            else
            {
                _departmentView.GetAll(result);
            }
        }
        public void GetById(int id)
        {

            var result = _departmentModel.GetById(id);
            if (result is null)
            {
                _departmentView.DataEmpty();
            }
            else
            {
                _departmentView.GetById(result);
            }
        }
        public void Insert()
        {
            var department = _departmentView.InsertMenu();
            var result = _departmentModel.Insert(department);

            switch (result)
            {
                case -1:
                    _departmentView.Error();
                    break;  
                case 0:
                    _departmentView.Failure();
                    break;
                default:
                    _departmentView.Success();
                    break;
            }
        }

        public void Update()
        {
            var department = _departmentView.UpdateMenu();
            var result = _departmentModel.Update(department);

            switch (result)
            {
                case -1:
                    _departmentView.Error();
                    break;
                case 0:
                    _departmentView.Failure();
                    break;
                default:
                    _departmentView.Success();
                    break;
            }
        }

        public void Delete()
        {
            var department = _departmentView.DeleteMenu();
            var result = (_departmentModel.Delete(department));

            switch (result)
            {
                case -1:
                    _departmentView.Error();
                    break;
                case 0:
                    _departmentView.Failure();
                    break;
                default:
                    _departmentView.Success();
                    break;
            }
        }
    }
}
