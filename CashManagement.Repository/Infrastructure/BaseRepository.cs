using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashManagement.Repository
{
    public class BaseRepository
    {
        public DbContext dbContext;
        public BaseRepository()
        {
            //可以在存取時加入處理 例如LOG
            //_dbContext.SavingChanges += _dbContext_SavingChanges;
        }

        private void _dbContext_SavingChanges(object sender, Microsoft.EntityFrameworkCore.SavingChangesEventArgs e)
        {
            if (sender is DbContext context)
            {
            }
        }
    }
}
