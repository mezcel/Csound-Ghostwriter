<CsoundSynthesizer>
<CsOptions>
-b 10000 ;;;bufer size in sample frames
-odac ;;;RT audio I/O
</CsOptions>
<CsInstruments>
nchnls = 1
instr 1
aq barmodel 1, 1, p4, 0.001, 0.23, 5, p5, p6, p7
out      aq
endin
</CsInstruments>
<CsScore>
i1 0 0.5 3 0.2 1000 0.05
i1 0.5 0.5 -3 0.3 2000 0.05
i1 1.0 0.5 -3 0.4 2000 0.1
i1 1.5 4.0 -3 0.5 1600 0.05
e
</CsScore>
</CsoundSynthesizer>




