using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Core
{
    
    public struct Signature
    {
        private string blockIDFlag { get; set; }
        private string validatorAddress { get; set; }
        private string timestamp { get; set; }
        private string signature { get; set; }

        public Signature(string idflag, string validator, string ts, string sig)
        {
            blockIDFlag = idflag;
            validatorAddress = validator;
            timestamp = ts;
            signature = sig;
        }
        public string getBlockIDFlag() => blockIDFlag;
        public string getValidatorAddress() => validatorAddress;
        public string getTimestamp() => timestamp;
        public string getSignature() => signature;

    }

    public struct Parts
    {
        private string total { get; set; }
        private string hash { get; set; }

        public Parts(string tot, string h)
        {
            total = tot;
            hash = h;
        }

        public string getTotal() => total;
        public string getHash() => hash;
    }

    public struct Version
    {
        private string block { get; set; }
        private string app { get; set; }

        public Version(string blk, string a)
        {
            block = blk;
            app = a;
        }

        public string getBlock() => block;
        public string getApp() => app;
    }

    public struct BlockID
    {
        private string hash { get; set; }
        private Parts partSetHeader { get; set; }

        public BlockID(string h, Parts part)
        {
            hash = h;
            partSetHeader = part;
        }

        public string getHash() => hash;
        public Parts getPartSetHeader() => partSetHeader;
    }

    public struct LastCommit
    {
        private string height { get; set; }
        private string round { get; set; }
        private BlockID blockID { get; set; }
        private Signature[] signatures { get; set; }

        public LastCommit(string h, string r, BlockID bid, Signature[] sigs)
        {
            height = h;
            round = r;
            signatures = sigs;
            blockID = bid;
        }

        public string getHeight() => height;
        public string getRound() => round;
        public Signature[] getSignatures() => signatures;
        public BlockID getBlockID() => blockID;
    }

    public struct Evidence
    {
        private string evidence { get; set; }

        public Evidence(string e)
        {
            evidence = e;
        }

        public string getEvidence() => evidence;
    }

    public struct Header
    {
        private Version version { get; set; }
        private string chainID { get; set; }
        private string height { get; set; }
        private string time { get; set; }
        private BlockID lastBlockID { get; set; }
        private string lastCommitHash { get; set; }
        private string dataHash { get; set; }
        private string validatorHash { get; set; }
        private string nextValidatorsHash { get; set; }
        private string consensusHash { get; set; }
        private string appHash { get; set; }
        private string lastResultsHash { get; set; }
        private string evidenceHash { get; set; }
        private string proposerAddress {get; set;}

        public Header(Version ver, string cid, string h, string t, BlockID lbid, string lchash, string dhash, string vhash, string nvhash,
            string chash, string ahash, string lrhash, string ehash, string paddress)
        {
            version = ver;
            chainID = cid;
            height = h;
            time = t;
            lastBlockID = lbid;
            lastCommitHash = lchash;
            dataHash = dhash;
            validatorHash = vhash;
            nextValidatorsHash = nvhash;
            consensusHash = chash;
            appHash = ahash;
            evidenceHash = ehash;
            lastResultsHash = lrhash;
            evidenceHash = ehash;
            proposerAddress = paddress;

        }
        public Version getVersion() => version;
        public string getChainID() => chainID;
        public string getHeight() => height;
        public string getTime() => time;
        public BlockID getBlockID() => lastBlockID;

        public string getLastCommitHash() => lastCommitHash;
        public string getDataHash() => dataHash;
        public string getValidatorHash() => validatorHash;
        public string getNextValidatorsHash() => nextValidatorsHash;
        public string getConsensusHash() => consensusHash;
        public string getAppHash() => appHash;
        public string getEvidenceHash() => evidenceHash;
        public string getProposerAddress() => proposerAddress;
    }

    struct BlockInfo
    {
        private BlockID blockID { get; set; }
        private Block block { get; set; }

        public BlockInfo(BlockID id, Block blk)
        {
            blockID = id;
            block = blk;
        }
        public BlockID getBlockID() => blockID;
        public Block getBlock() => block;
    }

    public class Block
    {
        private Header header { get; set; }
        private string[]? txsData { get; set; }
        private Evidence evidence { get; set; }
        private LastCommit lastCommit { get; set; }

        public Block(Header hdr, string[]? txs, Evidence e, LastCommit lc)
        {
            header = hdr;
            txsData = txs;
            evidence = e;
            lastCommit = lc;
        }

        public Header getHeader() => header;
        public string[]? getTxsData() => txsData;
        public Evidence GetEvidence() => evidence;
        public LastCommit getLastCommit() => lastCommit;
    }
}
