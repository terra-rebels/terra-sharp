namespace TerraSharp.Client.Lcd.Args.LcdClient.Subscriptions
{
    public enum TendermintEventType
    {
        NewBlock = 0,
        NewBlockHeader = 1,
        Evidence = 2,
        Tx = 3,
        ValidatorSetUpdates = 4,
        CompleteProposal = 5,
        Lock = 6,
        NewRound = 7,
        NewRoundStep = 8,
        Polka = 9,
        Relock = 10,
        TimeoutPropose = 11,
        TimeoutWait = 12,
        Unlock = 13,
        ValidBlock = 14,
        Vote = 15,
    }
}
