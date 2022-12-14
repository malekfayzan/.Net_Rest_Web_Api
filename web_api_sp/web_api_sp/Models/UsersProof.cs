using System;
using System.Collections.Generic;

namespace web_api_sp.Models
{
    public partial class UsersProof
    {
        public UsersProof()
        {
            UsersDetails = new HashSet<UsersDetail>();
        }

        public int UserProofId { get; set; }
        public string ProofName { get; set; } = null!;

        public virtual ICollection<UsersDetail> UsersDetails { get; set; }
    }
}
