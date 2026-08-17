using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTachesAdmin.Forms.Models
{
    public class Notification
    {
        public string ContenuNot { get; set; } = string.Empty;
        public int Id_notification { get; set; }
        public DateTime DateAnvoi { get; set; }

    }
}
