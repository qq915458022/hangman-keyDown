using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using cn.ifengge.hangman.library.store;
using cn.ifengge.hangman.library.ui;
using System.Runtime.InteropServices;



namespace Hangman_Steven
{

    public partial class Configure : Form,ExportImportDialog.OnPreferenceChangedListener
    {
        public Hangman mainForm;

        public Configure()
        {
            InitializeComponent();
            //MessageBox.Show(this, handleConfigFile("ni 1"));
        }

        //
        public int chooseFreqCommRare = 1;


        //根据1-3的值改变button的背景色
        public void num2BackColor(Button bt,int chooseFreqCommRare) 
        {
            if (chooseFreqCommRare == 1)
            {
                bt.BackColor = frequentButton.BackColor;
            }
            else if (chooseFreqCommRare == 2) 
            {
                bt.BackColor = commonButton.BackColor;
            }
            else if (chooseFreqCommRare == 3)
            {
                bt.BackColor = rareButton.BackColor;
            }
            else
            {
                MessageBox.Show("Error! this message should not be showed, if do, the code is wrong!");
            }
        }



        //读配置文件，初始化配置窗口
        public void readConfigureFile()
        {
            try
            {
                wordTrackBar.Value = Int32.Parse(GamePreference.Default.wordDistance);
                letterTrackBar.Value = Int32.Parse(GamePreference.Default.letterDistance);
                timerLength.Value = Int32.Parse(GamePreference.Default.timerCountdown);
                chooseSpeakLetter.Value = Int32.Parse(GamePreference.Default.speakLetterMode);
                chooseTeamMode.Value = Int32.Parse(GamePreference.Default.teamsMode);
                chooseLetterDisplay.Value = Int32.Parse(GamePreference.Default.displayTime);
                letterFailureText.Text = GamePreference.Default.letterFailure;
                letterSuccessText.Text = GamePreference.Default.letterSuccess;
                loseGameText.Text = GamePreference.Default.loseGame;
                gameWonText.Text = GamePreference.Default.gameWon;
                int rValue = Int32.Parse(GamePreference.Default.unClickedColor_R);
                int gValue = Int32.Parse(GamePreference.Default.unClickedColor_G);
                int bValue = Int32.Parse(GamePreference.Default.unClickedColor_B);
                unclickedButton.BackColor = Color.FromArgb(rValue, gValue, bValue);

                rValue = Int32.Parse(GamePreference.Default.usedColor_R);

                gValue = Int32.Parse(GamePreference.Default.usedColor_G);

                bValue = Int32.Parse(GamePreference.Default.usedColor_B);
                usedButton.BackColor = Color.FromArgb(rValue, gValue, bValue);

                rValue = Int32.Parse(GamePreference.Default.failedColor_R);

                gValue = Int32.Parse(GamePreference.Default.failedColor_G);

                bValue = Int32.Parse(GamePreference.Default.failedColor_B);
                failedButton.BackColor = Color.FromArgb(rValue, gValue, bValue);

                chooseFontSize.Value = Int32.Parse(GamePreference.Default.fontSize);
                //读9个数字，组合出3个Freq-Comm-Rare背景色

                rValue = Int32.Parse(GamePreference.Default.frequentButton_BackColor_R);

                gValue = Int32.Parse(GamePreference.Default.frequentButton_BackColor_G);

                bValue = Int32.Parse(GamePreference.Default.frequentButton_BackColor_B);
                frequentButton.BackColor = Color.FromArgb(rValue, gValue, bValue);

                rValue = Int32.Parse(GamePreference.Default.commonButton_BackColor_R);

                gValue = Int32.Parse(GamePreference.Default.commonButton_BackColor_G);

                bValue = Int32.Parse(GamePreference.Default.commonButton_BackColor_B);
                commonButton.BackColor = Color.FromArgb(rValue, gValue, bValue);

                rValue = Int32.Parse(GamePreference.Default.rareButton_BackColor_R);

                gValue = Int32.Parse(GamePreference.Default.rareButton_BackColor_G);

                bValue = Int32.Parse(GamePreference.Default.rareButton_BackColor_B);
                rareButton.BackColor = Color.FromArgb(rValue, gValue, bValue);
                //读26个数字，据此设置键盘26键的背景色

                num2BackColor(buttonA, Int32.Parse(GamePreference.Default.BackColor2Num_button_A));

                num2BackColor(buttonB, Int32.Parse(GamePreference.Default.BackColor2Num_button_B));

                num2BackColor(buttonC, Int32.Parse(GamePreference.Default.BackColor2Num_button_C));

                num2BackColor(buttonD, Int32.Parse(GamePreference.Default.BackColor2Num_button_D));

                num2BackColor(buttonE, Int32.Parse(GamePreference.Default.BackColor2Num_button_E));

                num2BackColor(buttonF, Int32.Parse(GamePreference.Default.BackColor2Num_button_F));

                num2BackColor(buttonG, Int32.Parse(GamePreference.Default.BackColor2Num_button_G));

                num2BackColor(buttonH, Int32.Parse(GamePreference.Default.BackColor2Num_button_H));

                num2BackColor(buttonI, Int32.Parse(GamePreference.Default.BackColor2Num_button_I));

                num2BackColor(buttonJ, Int32.Parse(GamePreference.Default.BackColor2Num_button_J));

                num2BackColor(buttonK, Int32.Parse(GamePreference.Default.BackColor2Num_button_K));

                num2BackColor(buttonL, Int32.Parse(GamePreference.Default.BackColor2Num_button_L));

                num2BackColor(buttonM, Int32.Parse(GamePreference.Default.BackColor2Num_button_M));

                num2BackColor(buttonN, Int32.Parse(GamePreference.Default.BackColor2Num_button_N));

                num2BackColor(buttonO, Int32.Parse(GamePreference.Default.BackColor2Num_button_O));

                num2BackColor(buttonP, Int32.Parse(GamePreference.Default.BackColor2Num_button_P));

                num2BackColor(buttonQ, Int32.Parse(GamePreference.Default.BackColor2Num_button_Q));

                num2BackColor(buttonR, Int32.Parse(GamePreference.Default.BackColor2Num_button_R));

                num2BackColor(buttonS, Int32.Parse(GamePreference.Default.BackColor2Num_button_S));

                num2BackColor(buttonT, Int32.Parse(GamePreference.Default.BackColor2Num_button_T));

                num2BackColor(buttonU, Int32.Parse(GamePreference.Default.BackColor2Num_button_U));

                num2BackColor(buttonV, Int32.Parse(GamePreference.Default.BackColor2Num_button_V));

                num2BackColor(buttonW, Int32.Parse(GamePreference.Default.BackColor2Num_button_W));

                num2BackColor(buttonX, Int32.Parse(GamePreference.Default.BackColor2Num_button_X));

                num2BackColor(buttonY, Int32.Parse(GamePreference.Default.BackColor2Num_button_Y));

                num2BackColor(buttonZ, Int32.Parse(GamePreference.Default.BackColor2Num_button_Z));
                //读6个数字，初始化加分减分权值

                chooseFrequentSuccess.Value = Int32.Parse(GamePreference.Default.chooseFrequentSuccess_Value);

                chooseFrequentFailure.Value = Int32.Parse(GamePreference.Default.chooseFrequentFailure_Value);

                chooseCommonSuccess.Value = Int32.Parse(GamePreference.Default.chooseCommonSuccess_Value);

                chooseCommonFailure.Value = Int32.Parse(GamePreference.Default.chooseCommonFailure_Value);

                chooseRareSuccess.Value = Int32.Parse(GamePreference.Default.chooseRareSuccess_Value);

                chooseRareFailure.Value = Int32.Parse(GamePreference.Default.chooseRareFailure_Value);
                //读一个数字，初始化每次失败出现的身体部分数目

                choosePenalty.Value = Int32.Parse(GamePreference.Default.choosePenalty_Value);
                //读一个字符串，数据文件存储路径

                updown_poser_size.Value = GamePreference.Default.poster_textsize;

                button2.BackColor = GamePreference.Default.background_screen;

                dataFileText.Text = GamePreference.Default.dataFileText_Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //配置窗口控件布局
        private void setPosition()
        {
            this.Width = 1100;
            this.Height = 620;
            

            //其他控件布局
            int widthDiv3 = this.Width / 3;
            int disMove = 10;//控件缩进距离
            int disBetweenLine = 5;//控件纵向的间距大小
            int disBetweenColum = 5;//同行控件的横向间距大小
            verticalLine1.Location = new Point(widthDiv3, 0);
            verticalLine1.Height = this.Height;
            verticalLine2.Location = new Point(widthDiv3 * 2, 0);
            verticalLine2.Height = this.Height;

            distanceLabel.Location = new Point(0, 0);
            wordLabel.Location = new Point(disMove, distanceLabel.Height + disBetweenLine);
            //wordTrackBar.Location = new Point(wordLabel.Location.X + wordLabel.Width+disBetweenColum, wordLabel.Location.Y);
            letterLabel.Location = new Point(disMove, wordLabel.Location.Y + wordLabel.Height + disBetweenLine);
            letterTrackBar.Location = new Point(letterLabel.Location.X + letterLabel.Width + disBetweenColum, letterLabel.Location.Y);
            wordTrackBar.Location = new Point(letterTrackBar.Location.X, wordLabel.Location.Y);
            wordTrackBar.Width = letterTrackBar.Width;
            wordTrackBar.Height = letterTrackBar.Height;
            numberLabel1.Location = new Point(letterTrackBar.Location.X, letterLabel.Location.Y + letterLabel.Height + disBetweenLine);
            
            TimerLabel.Location = new Point(0, numberLabel1.Location.Y + numberLabel1.Height + disBetweenLine * 5);
            timerLength.Location = new Point(TimerLabel.Location.X + TimerLabel.Width + disBetweenColum, TimerLabel.Location.Y);
            secondsLabel.Location = new Point(timerLength.Location.X + timerLength.Width + disBetweenColum, timerLength.Location.Y);

            dataFileLabel.Location = new Point(0, TimerLabel.Location.Y + TimerLabel.Height +disBetweenLine * 5);
            dataFileText.Location = new Point(disMove, dataFileLabel.Location.Y + dataFileLabel.Height +disBetweenLine);
            chooseDataFilebutton.Location = new Point(verticalLine1.Location.X - chooseDataFilebutton.Width - disBetweenColum,dataFileText.Location.Y);
            dataFileText.Width = chooseDataFilebutton.Location.X - disBetweenColum * 3;

            modeLabel.Location = new Point(0, dataFileText.Location.Y + dataFileText.Height + disBetweenLine * 5);
            speakLetterLabel.Location = new Point(disMove, modeLabel.Location.Y + modeLabel.Height + disBetweenLine);
            teamModeLabel.Location = new Point(disMove, speakLetterLabel.Location.Y + speakLetterLabel.Height + disBetweenLine * 3);
            letterDisplayLabel.Location = new Point(disMove, teamModeLabel.Location.Y + teamModeLabel.Height + disBetweenLine * 3);
            chooseLetterDisplay.Location = new Point(letterDisplayLabel.Location.X+letterDisplayLabel.Width+disBetweenColum, letterDisplayLabel.Location.Y);
            chooseSpeakLetter.Location = new Point(chooseLetterDisplay.Location.X, speakLetterLabel.Location.Y);
            chooseTeamMode.Location = new Point(chooseLetterDisplay.Location.X, teamModeLabel.Location.Y);

            //键盘布局
            buttonPanel.Location = new Point(0, letterDisplayLabel.Location.Y + letterDisplayLabel.Height + disBetweenLine * 10);

            //第二栏
            int startX1=verticalLine1.Location.X+verticalLine1.Width;
            perferenceLabel.Location = new Point(startX1, 0);

            musicLabel.Location = new Point(startX1 + disMove, perferenceLabel.Height + disBetweenLine);
            
            letterFailureLabel.Location = new Point(musicLabel.Location.X , musicLabel.Location.Y + musicLabel.Height + disBetweenLine);
            letterFailureText.Location = new Point(letterFailureLabel.Location.X, letterFailureLabel.Location.Y + letterFailureLabel.Height + disBetweenLine);
            chooseFailureButton.Location = new Point(verticalLine2.Location.X - chooseFailureButton.Width - disBetweenColum * 3, letterFailureText.Location.Y);
            letterFailureText.Width = chooseFailureButton.Location.X - letterFailureText.Location.X - disBetweenColum;

            letterSuccessLabel.Location = new Point(startX1 + disMove, chooseFailureButton.Location.Y + chooseFailureButton.Height + disBetweenLine);
            letterSuccessText.Location = new Point(letterSuccessLabel.Location.X, letterSuccessLabel.Location.Y + letterSuccessLabel.Height + disBetweenLine);
            chooseSuccessButton.Location = new Point(verticalLine2.Location.X - chooseSuccessButton.Width - disBetweenColum * 3, letterSuccessText.Location.Y);
            letterSuccessText.Width = letterFailureText.Width;

            loseLabel.Location=new Point(startX1+disMove,chooseSuccessButton.Location.Y+chooseSuccessButton.Height+disBetweenLine);
            loseGameText.Location=new Point(loseLabel.Location.X,loseLabel.Location.Y+loseLabel.Height+disBetweenLine);
            chooseLoseButton.Location=new Point(verticalLine2.Location.X-chooseLoseButton.Width-disBetweenColum*3,loseGameText.Location.Y);
            loseGameText.Width = letterFailureText.Width;

            wonLabel.Location = new Point(startX1 + disMove, chooseLoseButton.Location.Y + chooseLoseButton.Height + disBetweenLine);
            gameWonText.Location = new Point(wonLabel.Location.X, wonLabel.Location.Y + wonLabel.Height + disBetweenLine);
            chooseWonButton.Location = new Point(verticalLine2.Location.X - chooseWonButton.Width - disBetweenColum * 3, gameWonText.Location.Y);
            gameWonText.Width = letterFailureText.Width;

            colorLabel.Location = new Point(musicLabel.Location.X, gameWonText.Location.Y + gameWonText.Height + disBetweenLine * 5);
            unclickedButton.Location = new Point(colorLabel.Location.X, colorLabel.Location.Y + colorLabel.Height + disBetweenLine);
            usedButton.Location = new Point(unclickedButton.Location.X + unclickedButton.Width + disBetweenColum*2, unclickedButton.Location.Y);
            failedButton.Location = new Point(usedButton.Location.X + usedButton.Width + disBetweenColum*2, usedButton.Location.Y);

            fontSizeLabel.Location = new Point(colorLabel.Location.X, unclickedButton.Location.Y + unclickedButton.Height + disBetweenLine * 5);
            chooseFontSize.Location = new Point(fontSizeLabel.Location.X + fontSizeLabel.Width + disBetweenColum, fontSizeLabel.Location.Y);

            //第三栏
            int startX2 = verticalLine2.Location.X + verticalLine2.Width;
            scorePanel.Location = new Point(startX2, 0);
            scorePanel.Width = 360;
            scorePanel.Height = 400;//test code
            penaltyLabel.Location = new Point(0, 0);
            int start2 = scorePanel.Width / 3;
            int start3 = scorePanel.Width * 2 / 3;
            successLabel.Location = new Point(start2, penaltyLabel.Height + disBetweenLine);
            failureLabel.Location = new Point(start3, successLabel.Location.Y);
            frequentLabel.Location = new Point(disMove, successLabel.Location.Y + successLabel.Height + disBetweenLine * 5);
            chooseFrequentSuccess.Location = new Point(start2 + disBetweenColum * 3, frequentLabel.Location.Y);
            chooseFrequentFailure.Location = new Point(start3 + disBetweenColum * 3, frequentLabel.Location.Y);
            commonLabel.Location = new Point(disMove, frequentLabel.Location.Y + frequentLabel.Height + disBetweenLine * 5);
            chooseCommonSuccess.Location = new Point(start2 + disBetweenColum * 3, commonLabel.Location.Y);
            chooseCommonFailure.Location = new Point(start3 + disBetweenColum * 3, commonLabel.Location.Y);
            rareLabel.Location = new Point(disMove, commonLabel.Location.Y + commonLabel.Height + disBetweenLine * 5);
            chooseRareSuccess.Location = new Point(start2 + disBetweenColum * 3, rareLabel.Location.Y);
            chooseRareFailure.Location = new Point(start3 + disBetweenColum * 3, rareLabel.Location.Y);

            timeOutPenaltyLabel.Location = new Point(0, rareLabel.Location.Y + rareLabel.Height + disBetweenLine * 10);
            choosePenalty.Location = new Point(disMove*5, timeOutPenaltyLabel.Location.Y + timeOutPenaltyLabel.Height + disBetweenLine * 5);
            bodyPartLabel.Location = new Point(choosePenalty.Location.X + choosePenalty.Width + disBetweenColum, choosePenalty.Location.Y);

            //Cancle OK 布局
            cancleButton.Location = new Point(startX2 + disBetweenColum * 5, this.Height - cancleButton.Height - disBetweenLine * 10);
            okButton.Location = new Point(cancleButton.Location.X + cancleButton.Width + disBetweenColum * 10, cancleButton.Location.Y);
        }

        //写配置文件
        private void writeConfigureFile()
        {
                //将数据安全地存放在Dll中
                GamePreference.Default.wordDistance = wordTrackBar.Value.ToString();
                GamePreference.Default.letterDistance =  letterTrackBar.Value.ToString();
                GamePreference.Default.timerCountdown = timerLength.Value.ToString();
                GamePreference.Default.speakLetterMode = chooseSpeakLetter.Value.ToString();
                GamePreference.Default.teamsMode = chooseTeamMode.Value.ToString();
                GamePreference.Default.displayTime = chooseLetterDisplay.Value.ToString();

                GamePreference.Default.letterFailure = letterFailureText.Text;
                GamePreference.Default.letterSuccess = letterSuccessText.Text;
                GamePreference.Default.loseGame = loseGameText.Text;
                GamePreference.Default.gameWon = gameWonText.Text;

                GamePreference.Default.unClickedColor_R = unclickedButton.BackColor.R.ToString();
                GamePreference.Default.unClickedColor_G = unclickedButton.BackColor.G.ToString();
                GamePreference.Default.unClickedColor_B = unclickedButton.BackColor.B.ToString();
                GamePreference.Default.usedColor_R = usedButton.BackColor.R.ToString();
                GamePreference.Default.usedColor_G = usedButton.BackColor.G.ToString();
                GamePreference.Default.usedColor_B = usedButton.BackColor.B.ToString();
                GamePreference.Default.failedColor_R = failedButton.BackColor.R.ToString();
                GamePreference.Default.failedColor_G = failedButton.BackColor.G.ToString();
                GamePreference.Default.failedColor_B = failedButton.BackColor.B.ToString();
                GamePreference.Default.fontSize = chooseFontSize.Value.ToString();

                GamePreference.Default.frequentButton_BackColor_R = frequentButton.BackColor.R.ToString();
                GamePreference.Default.frequentButton_BackColor_G = frequentButton.BackColor.G.ToString();
                GamePreference.Default.frequentButton_BackColor_B = frequentButton.BackColor.B.ToString();
                GamePreference.Default.commonButton_BackColor_R = commonButton.BackColor.R.ToString();
                GamePreference.Default.commonButton_BackColor_G = commonButton.BackColor.G.ToString();
                GamePreference.Default.commonButton_BackColor_B = commonButton.BackColor.B.ToString();
                GamePreference.Default.rareButton_BackColor_R = rareButton.BackColor.R.ToString();
                GamePreference.Default.rareButton_BackColor_G = rareButton.BackColor.G.ToString();
                GamePreference.Default .rareButton_BackColor_B= rareButton.BackColor.B.ToString();

                GamePreference.Default.BackColor2Num_button_A = BackColor2Num(buttonA).ToString();
                GamePreference.Default.BackColor2Num_button_B = BackColor2Num(buttonB).ToString();
                GamePreference.Default.BackColor2Num_button_C = BackColor2Num(buttonC).ToString();
                GamePreference.Default.BackColor2Num_button_D = BackColor2Num(buttonD).ToString();
                GamePreference.Default.BackColor2Num_button_E = BackColor2Num(buttonE).ToString();
                GamePreference.Default.BackColor2Num_button_F = BackColor2Num(buttonF).ToString();
                GamePreference.Default.BackColor2Num_button_G = BackColor2Num(buttonG).ToString();
                GamePreference.Default.BackColor2Num_button_H = BackColor2Num(buttonH).ToString();
                GamePreference.Default.BackColor2Num_button_I = BackColor2Num(buttonI).ToString();
                GamePreference.Default.BackColor2Num_button_J = BackColor2Num(buttonJ).ToString();
                GamePreference.Default.BackColor2Num_button_K = BackColor2Num(buttonK).ToString();
                GamePreference.Default.BackColor2Num_button_L = BackColor2Num(buttonL).ToString();
                GamePreference.Default.BackColor2Num_button_M = BackColor2Num(buttonM).ToString();
                GamePreference.Default.BackColor2Num_button_N = BackColor2Num(buttonN).ToString();
                GamePreference.Default.BackColor2Num_button_O = BackColor2Num(buttonO).ToString();
                GamePreference.Default.BackColor2Num_button_P = BackColor2Num(buttonP).ToString();
                GamePreference.Default.BackColor2Num_button_Q = BackColor2Num(buttonQ).ToString();
                GamePreference.Default.BackColor2Num_button_R = BackColor2Num(buttonR).ToString();
                GamePreference.Default.BackColor2Num_button_S = BackColor2Num(buttonS).ToString();
                GamePreference.Default.BackColor2Num_button_T = BackColor2Num(buttonT).ToString();
                GamePreference.Default.BackColor2Num_button_U = BackColor2Num(buttonU).ToString();
                GamePreference.Default.BackColor2Num_button_V = BackColor2Num(buttonV).ToString();
                GamePreference.Default.BackColor2Num_button_W = BackColor2Num(buttonW).ToString();
                GamePreference.Default.BackColor2Num_button_X = BackColor2Num(buttonX).ToString();
                GamePreference.Default.BackColor2Num_button_Y = BackColor2Num(buttonY).ToString();
                GamePreference.Default.BackColor2Num_button_Z = BackColor2Num(buttonZ).ToString();

                GamePreference.Default.chooseFrequentSuccess_Value = chooseFrequentSuccess.Value.ToString();
                GamePreference.Default.chooseFrequentFailure_Value = chooseFrequentFailure.Value.ToString();
                GamePreference.Default.chooseCommonSuccess_Value = chooseCommonSuccess.Value.ToString();
                GamePreference.Default.chooseCommonFailure_Value = chooseCommonFailure.Value.ToString();
                GamePreference.Default.chooseRareSuccess_Value = chooseRareSuccess.Value.ToString();
                GamePreference.Default.chooseRareFailure_Value = chooseRareFailure.Value.ToString();

                GamePreference.Default.choosePenalty_Value = choosePenalty.Value.ToString();

                GamePreference.Default.poster_textsize = Int32.Parse(updown_poser_size.Value.ToString());

                GamePreference.Default.dataFileText_Text = dataFileText.Text;

                GamePreference.Default.Save();

                GamePreference.Default.background_screen = button2.BackColor;

                mainForm.gameListener.stopGame(mainForm.timerCountdown,mainForm.pb,mainForm.bt);

                mainForm.Hangman_Load(null,null) ;
        }

        //读键的背景色，与Freq-Comm-Rare键的背景色做对比，返回1-3值（出错的情况下返回4）
        private int BackColor2Num(Button bt) 
        {
            if (bt.BackColor == frequentButton.BackColor)
            {
                return 1;
            }
            else if(bt.BackColor==commonButton.BackColor)
            {
                return 2;
            }
            else if (bt.BackColor == rareButton.BackColor)
            {
                return 3;
            }
            else 
            {
                MessageBox.Show("Error! this message should not be showed, if do, the code is wrong!");
                return 4;
            }
        }

        //弹出选择文件窗口
        private string chooseFileDiag(string primaryString)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return primaryString;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return primaryString;
            }
        }

        //弹出Frequency选择窗口
        private void chooseFrequency()
        {
            freqComRare fcr = new freqComRare();
            fcr.configure = this;
            fcr.ShowDialog();//限制用户只能操作当前Frequency窗口，以免同时产生两个Frequency窗口
        }


        //配置窗口出现时的初始化程序
        private void configureForm_Load(object sender, EventArgs e)
        {
            //读配置文件，初始化配置窗口
            readConfigureFile();

            //配置窗口控件布局
            setPosition();

            mainForm.UseWaitCursor = false;
            
        }

        
        //Perference-Music
        private void chooseFailureButton_Click(object sender, EventArgs e)
        {
            //弹出选择文件窗口
            letterFailureText.Text = chooseFileDiag(letterFailureText.Text);
        }

        private void chooseSuccessButton_Click(object sender, EventArgs e)
        {
            //弹出选择文件窗口
            letterSuccessText.Text = chooseFileDiag(letterSuccessText.Text);
        }

        private void chooseLoseButton_Click(object sender, EventArgs e)
        {
            //弹出选择文件窗口
            loseGameText.Text = chooseFileDiag(loseGameText.Text);
        }

        private void chooseWonButton_Click(object sender, EventArgs e)
        {
            //弹出选择文件窗口
            gameWonText.Text = chooseFileDiag(gameWonText.Text);
        } 


        //Perference-Color
        private void unclickedButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = unclickedButton.BackColor;
            if(colorDialog.ShowDialog() == DialogResult.OK) unclickedButton.BackColor = colorDialog.Color;
        }

        private void usedButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = usedButton.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) usedButton.BackColor = colorDialog.Color;
        }

        private void failedButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = failedButton.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) failedButton.BackColor = colorDialog.Color;
        }




        //Cancle
        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ok
        private void okButton_Click(object sender, EventArgs e)
        {   
            //检查合理性(可能还需要继续补充其他代码，检查其他变量的合理性)
            if (letterTrackBar.Value >= wordTrackBar.Value)
            {
                MessageBox.Show("letter distance >= word distance is unresonable.\nMake sure letter distance < word distance.\nPlease set again.");
                return;
            }

            if (Int32.Parse(chooseTeamMode.Value.ToString()) <= 1)
            {
                chooseTeamMode.Value = 0;
            }

            //写配置文件
            writeConfigureFile();

            this.Close();
        }


        //无用方法-不必写任何内容
        private void timerLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chooseSpeakLetter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chooseTeamMode_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chooseLetterDisplay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lineLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lineLabel2_Click(object sender, EventArgs e)
        {

        }

        private void verticalLine1_Click(object sender, EventArgs e)
        {

        }

        private void wordTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void letterTrackBar_Scroll(object sender, EventArgs e)
        {

        }
        
        //显示各个字母被配置成Frequent-Common-Rare的状态
        private void buttonA_Click(object sender, EventArgs e)
        {
            chooseFrequency();
            num2BackColor(buttonA, chooseFreqCommRare);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }

        private void buttonD_Click(object sender, EventArgs e)
        {

        }

        private void buttonE_Click(object sender, EventArgs e)
        {

        }

        private void buttonF_Click(object sender, EventArgs e)
        {

        }

        private void buttonG_Click(object sender, EventArgs e)
        {

        }

        private void buttonH_Click(object sender, EventArgs e)
        {

        }

        private void buttonI_Click(object sender, EventArgs e)
        {

        }

        private void buttonJ_Click(object sender, EventArgs e)
        {

        }

        private void buttonK_Click(object sender, EventArgs e)
        {

        }

        private void buttonL_Click(object sender, EventArgs e)
        {

        }

        private void buttonM_Click(object sender, EventArgs e)
        {

        }

        private void buttonN_Click(object sender, EventArgs e)
        {

        }

        private void buttonO_Click(object sender, EventArgs e)
        {

        }

        private void buttonP_Click(object sender, EventArgs e)
        {

        }

        private void buttonQ_Click(object sender, EventArgs e)
        {

        }

        private void buttonR_Click(object sender, EventArgs e)
        {

        }

        private void buttonS_Click(object sender, EventArgs e)
        {

        }

        private void buttonT_Click(object sender, EventArgs e)
        {

        }

        private void buttonU_Click(object sender, EventArgs e)
        {

        }

        private void buttonV_Click(object sender, EventArgs e)
        {

        }

        private void buttonW_Click(object sender, EventArgs e)
        {

        }

        private void buttonX_Click(object sender, EventArgs e)
        {

        }

        private void buttonY_Click(object sender, EventArgs e)
        {

        }

        private void buttonZ_Click(object sender, EventArgs e)
        {

        }



        //检查buttonA-buttonZ，如果背景色与bckColor一样，就将其背景色改成newColor
        private void checkBackColor(Color bckColor,Color newColor)
        {
            if (buttonA.BackColor == bckColor)
                buttonA.BackColor = newColor;
            if (buttonB.BackColor == bckColor)
                buttonB.BackColor = newColor;
            if (buttonC.BackColor == bckColor)
                buttonC.BackColor = newColor;
            if (buttonD.BackColor == bckColor)
                buttonD.BackColor = newColor;
            if (buttonE.BackColor == bckColor)
                buttonE.BackColor = newColor;
            if (buttonF.BackColor == bckColor)
                buttonF.BackColor = newColor;
            if (buttonG.BackColor == bckColor)
                buttonG.BackColor = newColor;
            if (buttonH.BackColor == bckColor)
                buttonH.BackColor = newColor;
            if (buttonI.BackColor == bckColor)
                buttonI.BackColor = newColor;
            if (buttonJ.BackColor == bckColor)
                buttonJ.BackColor = newColor;
            if (buttonK.BackColor == bckColor)
                buttonK.BackColor = newColor;
            if (buttonL.BackColor == bckColor)
                buttonL.BackColor = newColor;
            if (buttonM.BackColor == bckColor)
                buttonM.BackColor = newColor;
            if (buttonN.BackColor == bckColor)
                buttonN.BackColor = newColor;
            if (buttonO.BackColor == bckColor)
                buttonO.BackColor = newColor;
            if (buttonP.BackColor == bckColor)
                buttonP.BackColor = newColor;
            if (buttonQ.BackColor == bckColor)
                buttonQ.BackColor = newColor;
            if (buttonR.BackColor == bckColor)
                buttonR.BackColor = newColor;
            if (buttonS.BackColor == bckColor)
                buttonS.BackColor = newColor;
            if (buttonT.BackColor == bckColor)
                buttonT.BackColor = newColor;
            if (buttonU.BackColor == bckColor)
                buttonU.BackColor = newColor;
            if (buttonV.BackColor == bckColor)
                buttonV.BackColor = newColor;
            if (buttonW.BackColor == bckColor)
                buttonW.BackColor = newColor;
            if (buttonX.BackColor == bckColor)
                buttonX.BackColor = newColor;
            if (buttonY.BackColor == bckColor)
                buttonY.BackColor = newColor;
            if (buttonZ.BackColor == bckColor)
                buttonZ.BackColor = newColor;
        }

        //个性化配置Freq-Comm-Rare的背景色
        private void frequentButton_Click(object sender, EventArgs e)
        {
            Color tmpColor = frequentButton.BackColor;
            colorDialog.Color = tmpColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) frequentButton.BackColor = colorDialog.Color;

            //检查buttonA-buttonZ，如果背景色与bckColor一样，就将其背景色改成newColor
            checkBackColor(tmpColor, frequentButton.BackColor);

        }

        private void commonButton_Click(object sender, EventArgs e)
        {
            Color tmpColor = commonButton.BackColor;
            colorDialog.Color = tmpColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) commonButton.BackColor = colorDialog.Color;

            //检查buttonA-buttonZ，如果背景色与bckColor一样，就将其背景色改成newColor
            checkBackColor(tmpColor, commonButton.BackColor);

        }

        private void rareButton_Click(object sender, EventArgs e)
        {
            Color tmpColor = rareButton.BackColor;
            colorDialog.Color = tmpColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) rareButton.BackColor = colorDialog.Color;

            //检查buttonA-buttonZ，如果背景色与bckColor一样，就将其背景色改成newColor
            checkBackColor(tmpColor, rareButton.BackColor);

        }

        private void choosePenalty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }






        //选择默认数据库文件路径
        private void chooseDataFilebutton_Click(object sender, EventArgs e)
        {
            dataFileText.Text = chooseFileDiag(dataFileText.Text);
        }






        private void dataFileText_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ExportImportDialog().setOnPreferenceListener(this).ShowDialog();
        }
        public void onPreferenceChanged()
        {
            readConfigureFile();
        }

        [DllImport("libhangman.dll")]
        public static extern String handleConfigFile(
            String input
        );

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog.Color = button2.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) button2.BackColor = colorDialog.Color;
        }
    }
}
