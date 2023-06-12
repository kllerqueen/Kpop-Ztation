using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        public List<int> tranHead = new List<int>();
        public List<TransactionDetail> tranDetail = new List<TransactionDetail>();

        public List<int> getAllTransactionHeaderID()
        {
            return (from TransactionHeader in db.TransactionHeaders where TransactionHeader.CustomerID == (int)Session["User"] select TransactionHeader.TransactionID).ToList();
        }

        public List<TransactionDetail> getAllTransactionDetail(int transactionId)
        {
            return (from TransactionDetail in db.TransactionDetails where TransactionDetail.TransactionID == transactionId select TransactionDetail).ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            tranHead = getAllTransactionHeaderID();
            foreach (var tran in tranHead)
            {
                List<TransactionDetail> tranTempList = getAllTransactionDetail(tran);
                foreach (var tranDet in tranTempList)
                {
                    tranDetail.Add(tranDet);
                }
            }
        }
    }
}