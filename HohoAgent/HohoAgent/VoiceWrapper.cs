using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeechLib;
using System.Collections;
using System.Diagnostics;

namespace HohoAgent
{
    public class VoiceWrapper
    {
        private static VoiceWrapper instance = new VoiceWrapper();

        public static VoiceWrapper Instance
        {
            get { return instance; }
        }

        SpVoice speechVoice;
        List<SpObjectToken> speechObjectTokens;

        private VoiceWrapper()
        {
            Init();
        }
        
        private void Init()
        {
            speechVoice = new SpVoice();
            speechObjectTokens = new List<SpObjectToken>();

            ISpeechObjectTokens voice_tokens = speechVoice.GetVoices();

            for (int i = 0; i < voice_tokens.Count; i++ )
            {
                SpObjectToken token = voice_tokens.Item(i);
                speechObjectTokens.Add(token);
            }
        }

        public ArrayList VoiceNames
        {
            get
            {
                ArrayList name_list = new ArrayList();
                foreach (SpObjectToken token in speechObjectTokens)
                {
                    string name = token.GetAttribute("Name");
                    name_list.Add(name);
                }
                return name_list;
            }
        }

        public void SetVoiceByIdx(int idx)
        {
            if ( idx >= speechObjectTokens.Count ) 
                return;

            SpObjectToken token = speechObjectTokens[idx];
           
            speechVoice.Voice = token;
        }

        public void Speak(string text, SpeechVoiceSpeakFlags SpFlags)
        {
            speechVoice.Speak(text, SpFlags);
        }

        public void SpeakAsyncCancelAll()
        {
            speechVoice.Speak(null, SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
            speechVoice.Resume();
        }

        public event _ISpeechVoiceEvents_VisemeEventHandler Viseme
        {
            add { speechVoice.Viseme += value; }
            remove { speechVoice.Viseme -= value; }
        }

        public event _ISpeechVoiceEvents_WordEventHandler Word
        {
            add { speechVoice.Word += value; }
            remove { speechVoice.Word -= value; }
        }
    }

}
