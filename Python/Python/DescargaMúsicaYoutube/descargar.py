from pytube import YouTube
from pytube import Playlist

yt = YouTube("https://www.youtube.com/watch?v=S0_888ZjlAA")
t = yt.streams.filter(only_audio=True)

t[0].download('C:\\Users\\TilteDango\\Music\\pypfile')
