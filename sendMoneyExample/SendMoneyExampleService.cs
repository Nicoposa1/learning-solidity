using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using SolidtyBootcamp.Contracts.sendMoneyExample.ContractDefinition;

namespace SolidtyBootcamp.Contracts.sendMoneyExample
{
    public partial class SendMoneyExampleService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, SendMoneyExampleDeployment sendMoneyExampleDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<SendMoneyExampleDeployment>().SendRequestAndWaitForReceiptAsync(sendMoneyExampleDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, SendMoneyExampleDeployment sendMoneyExampleDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<SendMoneyExampleDeployment>().SendRequestAsync(sendMoneyExampleDeployment);
        }

        public static async Task<SendMoneyExampleService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, SendMoneyExampleDeployment sendMoneyExampleDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, sendMoneyExampleDeployment, cancellationTokenSource);
            return new SendMoneyExampleService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public SendMoneyExampleService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> ReciveMoneyRequestAsync(ReciveMoneyFunction reciveMoneyFunction)
        {
             return ContractHandler.SendRequestAsync(reciveMoneyFunction);
        }

        public Task<string> ReciveMoneyRequestAsync()
        {
             return ContractHandler.SendRequestAsync<ReciveMoneyFunction>();
        }

        public Task<TransactionReceipt> ReciveMoneyRequestAndWaitForReceiptAsync(ReciveMoneyFunction reciveMoneyFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(reciveMoneyFunction, cancellationToken);
        }

        public Task<TransactionReceipt> ReciveMoneyRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<ReciveMoneyFunction>(null, cancellationToken);
        }
    }
}
