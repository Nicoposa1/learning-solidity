// SPDX-License-Identifier: GPL-3.0

pragma solidity ^0.8.1;

contract sendMoneyExample {
  function reciveMoney() public payable{

  }

  function getBalnce() public view returns (uint) {
    return address(this).balance;
  }

}
