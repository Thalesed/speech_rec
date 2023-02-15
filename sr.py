import speech_recognition as sr

r = sr.Recognizer()

alex = sr.AudioFile('speech2.wav')

with alex as source:
    audio = r.record(source)

txt = r.recognize_google(audio, language="pt-BR")

fl = open("speech", "w")
fl.write(txt)
fl.close()