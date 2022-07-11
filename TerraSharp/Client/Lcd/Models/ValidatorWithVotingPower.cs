using TerraSharp.Core.Staking;

namespace TerraSharp.Client.Lcd.Models
{
    public class ValidatorWithVotingPower
    {
        public Validator ValidatorInfo { get; set; }
        public int VotingPower { get; set; }
        public int ProposerPriority { get; set; }
    }
}
