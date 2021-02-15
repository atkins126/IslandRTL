﻿'''<summary>The TrackEvent interface, which is part of the HTML DOM specification, is used for events which represent changes to a set of available tracks on an HTML media element; these events are addtrack and removetrack.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [TrackEvent]
  '''<summary>The DOM track object the event is in reference to. If not null, this is always an object of one of the media track types: AudioTrack, VideoTrack, or TextTrack).</summary>
  ReadOnly Property [track] As TextTrack
End Interface