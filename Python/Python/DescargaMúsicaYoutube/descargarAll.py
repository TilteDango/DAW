import re
from pytube import Playlist

YOUTUBE_STREAM_AUDIO = '140'
DOWNLOAD_DIR = 'C:\\Users\\TilteDango\\Music\\pypfile'

playlist = Playlist('https://www.youtube.com/playlist?list=PLRW7iEDD9RDStI3Uc2RCFbqdilK2pQO97')

playlist._video_regex = re.compile(r"\"url\":\"(/watch\?v=[\w-]*)")

print(len(playlist.video_urls))

for video in playlist.videos:
    audioStream = video.streams.get_by_itag(YOUTUBE_STREAM_AUDIO)
    audioStream.download(output_path=DOWNLOAD_DIR)