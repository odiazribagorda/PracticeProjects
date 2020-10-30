from pygame import mixer
import time

def set_alarm(alarm_time, sound_file, message):
    """
    To reduce busy waiting I sleep the thread but
    probably best implemented by scheduler as suggested.
    """
    while(time.time() < alarm_time):
        time.sleep(1)
    mixer.init()
    mixer.music.load(sound_file)
    mixer.music.play()
    print(message)
    input('Press any key to stop')
    mixer.music.stop()