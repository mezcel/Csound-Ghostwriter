<CsoundSynthesizer>
<CsOptions>
-o C:\Users\mezcel\Documents\MezWave.wav
-b 10000 ;;;bufer size in sample frames
-odac -iadc ;;;RT audio I/O
</CsOptions>
 
<CsInstruments>
sr = 44100
kr = 4410
ksmps = 10
nchnls = 1
 
instr 1
ffgh pvsosc 20000 , 962 , 1 , 1024
afgh pvsynth ffgh
afgh
endin
 
</CsInstruments>
 
<CsScore>
i 1 0 1
e
</CsScore>
 
</CsoundSynthesizer>
 
