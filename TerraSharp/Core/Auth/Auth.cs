using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Core.Auth
{
    public class Auth
    {
        public Auth()
        {
            //default CTOR
        }

        /* FROM: ./terra.js-main/src/core/auth/index::TODO
         * 
         * public bool isVesting(account acct) - Checks whether the account is actively used for vesting or not.
         * Params: Account acct - The account to check.
         * 
         * NOTE: The function described only is checking whether the account is of type LazyGradedVestingAccount 
         * as per notes in the TODO section, even though there are multiple Vesiting Account types. 
         * for this fuction we will be checking against all Vesting types.
         */

        public bool isVesting(Account acc) => acc.GetType() == typeof(BaseVestingAccount) ||
            acc.GetType() == typeof(ContinuousVestingAccount) ||
            acc.GetType() == typeof(DelayedVestingAccount) ||
            acc.GetType() == typeof(LazyGradedVestingAccount) || acc.GetType() == typeof(PeriodicVestingAccount);
    }
}
