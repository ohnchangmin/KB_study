using gymManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymManagement.controller
{
    class Adapter
    {
        private OraController orc;
        List<Trainer> listTrainer = new List<Trainer>();

        public Adapter(OraController orc)
        {
            this.orc = orc;
        }
        public List<Trainer> getTrainerVo()
        {
            listTrainer = orc.getTrainerDb();
            return listTrainer;
        }
    }
}
