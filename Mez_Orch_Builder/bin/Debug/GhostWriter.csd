<CsoundSynthesizer>
<CsOptions>
-o MezWave.wav -W
 -b 10000 ;;;bufer size in sample frames
 -odac ;;;RT audio I/O
</CsOptions>
 
<CsInstruments>
sr = 44100
kr = 4410
ksmps = 10
nchnls = 1
 
instr 1
kenv1 adsr 0.1 , 0.9 , 0.9 , 0.7
fasdfgh pvsosc 1492 * kenv1 , 300 , 1 , 1024
aasdfgh pvsynth fasdfgh
alpresasdfgh bqrez aasdfgh , 2304 , 2304, 0
ahpresasdfgh bqrez alpresasdfgh , 219 , 219, 1
anormalOut balance ahpresasdfgh , ahpresasdfgh
out anormalOut
endin
 
</CsInstruments>
 
<CsScore>
i 1 0 1
e
</CsScore>
 
;;; =========== .csd directory ============================ 
;;; C:\Users\mezcel\Documents\Ghost_Writer\Mez_Orch_Builder_v12\Mez_Orch_Builder\bin\Debug\GhostWriter.csd
</CsoundSynthesizer>
 
