// SPDX-License-Identifier: GPL-3.0

pragma solidity ^0.8.1;

contract sendMoneyExample {

  uint public balanceRecived;

  function reciveMoney() public payable{

  }

  function getBalance() public view returns (uint) {
    return address(this).balance;
  }

  function withdrawMoney() public{
    address payable to = payable(msg.sender);
    to.transfer(this.getBalance());
  }

  function withdrawMoneyTo(address payable _to) public payable{
    _to.transfer(this.getBalance());
  }

}
