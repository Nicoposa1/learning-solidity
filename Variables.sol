// SPDX-License-Identifier: GPL-3.0

pragma solidity ^0.8.1;

contract WorkingWithVariable {
    /* setear un numero */
    uint256 public myUint;
    
    function setMyUint(uint _myUint) public{
        myUint = _myUint;
    }
    
    /* crear booleanos */
    
    bool public myBool;
    
    function setMyBool(bool _myBool) public{
        myBool = _myBool;
    }
    
    /* incrementar y decrementar uint */
    
    uint8 public myUint8;
    
    function incrementUint() public {
        myUint8 ++;
    }
    
    function decrementUint() public {
        myUint8 --;
    }
    
    /* agregar una dirección de cartera */
    
    address public myAddress;
    
    function setAddress(address _address) public{
        myAddress = _address;
    }
    
    /* cantidad de wei tiene una cartera */
    
    function getBalanceAddress () public view returns(uint){
        return myAddress.balance;
    }
    
    /* strings */
    
    string public myString;
    
    function setMyString(string memory _myString) public {
        myString = _myString;
    }
    
}