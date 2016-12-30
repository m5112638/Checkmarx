using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;

namespace Checkmarx.Models
{
    public class BankingViewModel
    {
        [Required]
        [Display(Name = "Transfer Amount")]
        public uint TransferAmount { get; set; }
    }

    public class HistoryViewModel
    {
        private static readonly List<KeyValuePair<uint, DateTime>> m_history = new List<KeyValuePair<uint, DateTime>>();

        public HistoryViewModel()
        {
        }

        [Required]
        [Display(Name = "Transfer History")]
        public List<string> Histroy
        {
            get
            {
                List<string> history = new List<string>();
                foreach (var h in m_history)
                    history.Add(string.Format("{0}: {1}", h.Value, h.Key));
                return history;
            }
        }

        public void Add(uint amount, DateTime transferTime)
        {
            m_history.Add(new KeyValuePair<uint, DateTime>(amount, transferTime));
        }
    }
}
