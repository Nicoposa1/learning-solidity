using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace SolidtyBootcamp.Contracts.sendMoneyExample.ContractDefinition
{


    public partial class SendMoneyExampleDeployment : SendMoneyExampleDeploymentBase
    {
        public SendMoneyExampleDeployment() : base(BYTECODE) { }
        public SendMoneyExampleDeployment(string byteCode) : base(byteCode) { }
    }

    public class SendMoneyExampleDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "6080604052348015600f57600080fd5b50605980601d6000396000f3fe608060405260043610601c5760003560e01c80633afa8ebd146021575b600080fd5b00fea2646970667358221220c37f8dc68fd93d41102a574b0f75c30179121fd5e0454be8b9bc99e90ac8062b64736f6c63430008090033";
        public SendMoneyExampleDeploymentBase() : base(BYTECODE) { }
        public SendMoneyExampleDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class ReciveMoneyFunction : ReciveMoneyFunctionBase { }

    [Function("reciveMoney")]
    public class ReciveMoneyFunctionBase : FunctionMessage
    {

    }


}
