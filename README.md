Welcome to neo-solidity repository.

The idea of this repository is to unify tools that seek to provide support of Solidity language for NEO platform.

Solidity is a domain-specific language aiming the Ethereum blockchain smart contracts, proposed and implemented by Ethereum team  (Gavin Wood/Vitalik Buterin/et al).
NEO platform intends to provide blockchain support for smart contracts written in many general purpose programming
languages, currently supporting C#, Python, Java, Go and many others.
So, the objective of this project is to provide a variant of Solidity for NEO, which we call NeoSol.

Both architectures (Ethereum/NEO) define a virtual machine with exclusive opcodes, that have many things in common.
However, there are differences that may limit the complete port of Solidity for NEO (and the reverse is also true, porting general purpose languages for Ethereum), so the idea is to keep the most of the original Solidity language, and use annotations to help the compiling process when a direct translation is not fully possible.

This project will be organized in stages:

1) Initially, many code mappings will be provided from Solidity to C#, Python and Java (currently most used languages for NEO)

1) Studies will be performed on the compatibility between both platforms (and annotations can be proposed in this stage)

1) One compiler (or many) will be written to provide translations of NeoSol to C#, Python and Java

1) Support for NeoSol will be added to neocompiler.io project

1) Direct AVM code generation from NeoSol will be pursued in a next step

Feel free to join our group and, if you like the idea, contribute with us!

NeoSol team (part of NeoResearch team)

MIT License, Copyleft 2018
