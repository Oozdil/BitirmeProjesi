from gtts import gTTS


def CreateSound (name,soundText):
    tts = gTTS(text=soundText, lang='tr')
    tts.save(name)
    print ("1")




import sys
try:
    text=str(sys.argv[2])
    name=str(sys.argv[1])
    CreateSound (name,text)
    #CreateSound ("test.mp3","test")
    #print(name,text)
except:
    print("0")


