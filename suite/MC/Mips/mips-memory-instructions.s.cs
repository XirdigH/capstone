# CS_ARCH_MIPS, CS_MODE_MIPS32, None
0x10,0x00,0xa4,0xa0 = sb $a0, 16($a1)
0x10,0x00,0xa4,0xe0 = sc $a0, 16($a1)
0x10,0x00,0xa4,0xa4 = sh $a0, 16($a1)
0x10,0x00,0xa4,0xac = sw $a0, 16($a1)
0x00,0x00,0xa7,0xac = sw $a3, 0($a1)
0x10,0x00,0xa2,0xe4 = swc1 $f2, 16($a1)
0x10,0x00,0xa4,0xa8 = swl $a0, 16($a1)
0x04,0x00,0xa4,0x80 = lb $a0, 4($a1)
0x04,0x00,0xa4,0x8c = lw $a0, 4($a1)
0x04,0x00,0xa4,0x90 = lbu $a0, 4($a1)
0x04,0x00,0xa4,0x84 = lh $a0, 4($a1)
0x04,0x00,0xa4,0x94 = lhu $a0, 4($a1)
0x04,0x00,0xa4,0xc0 = ll $a0, 4($a1)
0x04,0x00,0xa4,0x8c = lw $a0, 4($a1)
0x00,0x00,0xe7,0x8c = lw $a3, 0($7)
0x10,0x00,0xa2,0x8f = lw $v0, 16($sp)
