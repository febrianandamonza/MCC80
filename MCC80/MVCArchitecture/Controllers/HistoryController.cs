using MVCArchitecture.Models;
using MVCArchitecture.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Controllers
{
    public class HistoryController
    {
        private History _historyModel;
        private VHistory _historyView;

        public HistoryController (History historyModel, VHistory historyView)
        {
            _historyModel = historyModel;
            _historyView = historyView;
        }

        public void GetAll()
        {
            var result = _historyModel.GetAll();
            if (result.Count is 0)
            {
                _historyView.DataEmpty();
            }
            else
            {
                _historyView.GetAll(result);
            }
        }

        public void GetById(int id)
        {

            var result = _historyModel.GetById(id);
            if (result is null)
            {
                _historyView.DataEmpty();
            }
            else
            {
                _historyView.GetById(result);
            }
        }

        public void Insert()
        {
            var history = _historyView.InsertMenu();
            var result = _historyModel.Insert(history);

            switch (result)
            {
                case -1:
                    _historyView.Error();
                    break;
                case 0:
                    _historyView.Failure();
                    break;
                default:
                    _historyView.Success();
                    break;
            }
        }

        public void Update()
        {
            var history = _historyView.UpdateMenu();
            var result = _historyModel.Update(history);

            switch (result)
            {
                case -1:
                    _historyView.Error();
                    break;
                case 0:
                    _historyView.Failure();
                    break;
                default:
                    _historyView.Success();
                    break;
            }
        }

        public void Delete(string start_date, int employee_id)
        {
            var result = (_historyModel.Delete(start_date,employee_id));

            switch (result)
            {
                case -1:
                    _historyView.Error();
                    break;
                case 0:
                    _historyView.Failure();
                    break;
                default:
                    _historyView.Success();
                    break;
            }
        }
    }
}
