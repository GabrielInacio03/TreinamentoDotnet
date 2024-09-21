using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class ErrorDeProposito : Exception
    {
        public ErrorDeProposito(string erro) : base(erro) { }
    }
}
