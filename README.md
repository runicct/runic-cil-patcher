# Runic CIL Patcher
The CIL Patcher provides a lightweight way to patch CIL Bytecode without having to implement
a full disassembler and emitter. The user is supposed to create their own patcher class that
inherith from the Runic.CIL.Patcher and then the user can override any instructions that they
intend to patch.

A common use case for this library is to inline short function or patch method / type tokens.
