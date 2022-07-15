namespace TerraSharp.Client.Lcd.Args.LcdClient
{
    public class LCDClientConfigArgs
    {
        public double? GasAdjustment { get; set; }
    }

    public class ValidatorWithVotingPower
    {
       // public Validator ValidatorInfo { get; set; }
        public int VotingPower { get; set; }
        public int ProposerPriority { get; set; }
    }
}
