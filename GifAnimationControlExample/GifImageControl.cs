using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.ComponentModel;

namespace HiimelOyun.App.Base.Controls
{
    public class GifImageControl : PictureBox
    {
        public event EventHandler AnimationCycleEnd;

        private Thread timer;
        private event EventHandler ticking;

        public int AnimationSpeed { get; set; }
        public int FrameCount { get; set; }
        public int FrameIndex { get; set; }
        private FrameDimension Dimension { get; set; }
        
        private Image _LoadingImage;
        public Image LoadingImage
        {
            get { return _LoadingImage; }
            set
            {
                _LoadingImage = value;
                if (_LoadingImage == null) return;

                Dimension = new FrameDimension(_LoadingImage.FrameDimensionsList[0]);
                FrameCount = _LoadingImage.GetFrameCount(Dimension);
                FrameIndex = 0;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public int ImageIndex { get; private set; }
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public List<Image> Images { get; private set; }
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public bool IsCycleByImages { get; set; }

        public GifImageControl()
        {
            Images = new List<System.Drawing.Image>();
            AnimationSpeed = 100;

            timer = new Thread(tick);
            timer.Start();
            
            ticking += new EventHandler(GifAnimationControl_ticking);
        }

        void GifAnimationControl_ticking(object sender, EventArgs e)
        {
            Application.DoEvents();

            if (_LoadingImage == null) return;

            if (FrameIndex >= FrameCount)
            {
                FrameIndex = 0;

                if (AnimationCycleEnd != null)
                {
                    this.Invoke(AnimationCycleEnd, new object[] { sender, e });
                }

                if (IsCycleByImages)
                {
                    if (Images != null && Images.Count > 0)
                    {
                        if (ImageIndex >= Images.Count) ImageIndex = 0;

                        LoadingImage = Images[ImageIndex];
                        ImageIndex++;
                    }
                }
            }

            _LoadingImage.SelectActiveFrame(Dimension, FrameIndex);
            Image = _LoadingImage;
            FrameIndex++;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if(timer.ThreadState == ThreadState.Aborted) timer.Start();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (timer.ThreadState != ThreadState.Aborted) timer.Abort();
            base.OnHandleDestroyed(e);
        }

        void tick()
        {
            try
            {
                while (true)
                {
                    try
                    {
                        Thread.Sleep(AnimationSpeed);

                        if (ticking != null)
                        {
                            this.Invoke(ticking, new object[] { this, EventArgs.Empty });
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }
    }
}
