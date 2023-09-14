from pytube import YouTube
from moviepy.editor import VideoFileClip

video_url = input("Digite a url do vídeo a extrair o áudio:")
yt = YouTube(video_url)
video_stream = yt.streams.get_highest_resolution()
video_filename = yt.title + '.mp4'
video_stream.download(filename=video_filename)
video_clip = VideoFileClip(video_filename)
audio_filename = yt.title + '.mp3'
video_clip.audio.write_audiofile(audio_filename)
video_clip.close()
video_clip.reader.close()
video_clip.audio.reader.close_proc()
print("áudio extraído com sucesso!")