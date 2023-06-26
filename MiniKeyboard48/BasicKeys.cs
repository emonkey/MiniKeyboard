using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MiniKeyboard48
{
	internal class BasicKeys : UserControl
	{
		private IContainer components;
		private Button KEY_A;
		private Button KEY_B;
		private Button KEY_C;
		private Button KEY_D;
		private Button KEY_E;
		private Button KEY_F;
		private Button KEY_G;
		private Button KEY_H;
		private Button KEY_I;
		private Button KEY_J;
		private Button KEY_K;
		private Button KEY_L;
		private Button KEY_M;
		private Button KEY_N;
		private Button KEY_O;
		private Button KEY_P;
		private Button KEY_Q;
		private Button KEY_R;
		private Button KEY_S;
		private Button KEY_T;
		private Button KEY_U;
		private Button KEY_V;
		private Button KEY_W;
		private Button KEY_X;
		private Button KEY_Y;
		private Button KEY_Z;

		private Button KEY_0;
		private Button KEY_9;
		private Button KEY_8;
		private Button KEY_7;
		private Button KEY_6;
		private Button KEY_5;
		private Button KEY_4;
		private Button KEY_3;
		private Button KEY_2;
		private Button KEY_1;

		private Button KEY_F12;
		private Button KEY_F11;
		private Button KEY_F10;
		private Button KEY_F9;
		private Button KEY_F8;
		private Button KEY_F7;
		private Button KEY_F6;
		private Button KEY_F5;
		private Button KEY_F4;
		private Button KEY_F3;
		private Button KEY_F2;
		private Button KEY_F1;

		private Button KEY_ESC;
		private Button KEY_PrtSc;
		private Button KEY_PauseBreak;
		private Button KEY_INS;
		private Button KEY_DEL;
		private Button KEY_HOME;
		private Button KEY_PgUP;
		private Button KEY_PgDN;
		private Button KEY_End;
		private Button KEY_SubSub;
		private Button KEY_ADDADD;
		private Button KEY_BACKSPACE;
		private Button KEY_TAB;
		private Button KEY_LEFT_SQBrace;
		private Button KEY_RIGHT_SQBrace;
		private Button KEY_PIPE;
		private Button KEY_COLON;
		private Button KEY_QUOTE;
		private Button KEY_Enter;
		private Button KEY_TILDE;
		private Button KEY_COMMA;
		private Button KEY_PERIOD;
		private Button KEY_QUESTION;

		private Button KEY_Arrow_left;
		private Button KEY_Arrow_Up;
		private Button KEY_Arrow_Down;
		private Button KEY_Arrow_right;
		
		private Button KEY_add;
		private Button KEY_sub;
		private Button KEY_multiply;
		private Button KEY_DIV;
		private Button KEY_NUM;
		private Button KEY_MIN_0;
		private Button KEY_MIN_9;
		private Button KEY_MIN_8;
		private Button KEY_MIN_7;
		private Button KEY_MIN_6;
		private Button KEY_MIN_5;
		private Button KEY_MIN_4;
		private Button KEY_MIN_3;
		private Button KEY_MIN_2;
		private Button KEY_MIN_1;
		private Button KEY_MIN_Dot;

		private Button KEY_CapsLock;
		private Button KEY_SpaceKey;
		private Button KEY_ScrollLock;
		private Button KEY_Menu;
		private Button Key_Ctrl;
		private Button Key_Shift;
		private Button Key_Alt;
		private Button Key_Win;

		public BasicKeys() => InitializeComponent();

		private void General_Char_Set()
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 1;
			FormMain.KeyParam.Key_Char_Num += 2;
			++FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyGroup_CharNum];
		}

		#region Key Selection Event Handlers

		private void KEY_A_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 4;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "A";
			General_Char_Set();
		}

		private void KEY_B_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 5;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "B";
			General_Char_Set();
		}

		private void KEY_C_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 6;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "C";
			General_Char_Set();
		}

		private void KEY_D_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 7;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "D";
			General_Char_Set();
		}

		private void KEY_E_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 8;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "E";
			General_Char_Set();
		}

		private void KEY_F_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 9;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F";
			General_Char_Set();
		}

		private void KEY_G_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 10;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "G";
			General_Char_Set();
		}

		private void KEY_H_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 11;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "H";
			General_Char_Set();
		}

		private void KEY_I_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 12;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "I";
			General_Char_Set();
		}

		private void KEY_J_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 13;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "J";
			General_Char_Set();
		}

		private void KEY_K_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 14;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "K";
			General_Char_Set();
		}

		private void KEY_L_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 15;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "L";
			General_Char_Set();
		}

		private void KEY_M_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 16;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "M";
			General_Char_Set();
		}

		private void KEY_N_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 17;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "N";
			General_Char_Set();
		}

		private void KEY_O_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 18;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "O";
			General_Char_Set();
		}

		private void KEY_P_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 19;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "P";
			General_Char_Set();
		}

		private void KEY_Q_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 20;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Q";
			General_Char_Set();
		}

		private void KEY_R_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 21;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "R";
			General_Char_Set();
		}

		private void KEY_S_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 22;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "S";
			General_Char_Set();
		}

		private void KEY_T_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 23;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "T";
			General_Char_Set();
		}

		private void KEY_U_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 24;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "U";
			General_Char_Set();
		}

		private void KEY_V_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 25;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "V";
			General_Char_Set();
		}

		private void KEY_W_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 26;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "W";
			General_Char_Set();
		}

		private void KEY_X_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 27;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "X";
			General_Char_Set();
		}

		private void KEY_Y_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 28;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Y";
			General_Char_Set();
		}

		private void KEY_Z_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 29;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Z";
			General_Char_Set();
		}

		private void KEY_1_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 30;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "!1";
			General_Char_Set();
		}

		private void KEY_2_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 31;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "@2";
			General_Char_Set();
		}

		private void KEY_3_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 32;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "#3";
			General_Char_Set();
		}

		private void KEY_4_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 33;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "$4";
			General_Char_Set();
		}

		private void KEY_5_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 34;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "%5";
			General_Char_Set();
		}

		private void KEY_6_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 35;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "^6";
			General_Char_Set();
		}

		private void KEY_7_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 36;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "&7";
			General_Char_Set();
		}

		private void KEY_8_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 37;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "*8";
			General_Char_Set();
		}

		private void KEY_9_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 38;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "(9";
			General_Char_Set();
		}

		private void KEY_0_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 39;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = ")0";
			General_Char_Set();
		}

		private void KEY_Enter_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 40;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Enter";
			General_Char_Set();
		}

		private void KEY_ESC_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 41;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "ESC";
			General_Char_Set();
		}

		private void KEY_BACKSPACE_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 42;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "BackSpace";
			General_Char_Set();
		}

		private void KEY_TAB_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 43;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Tab";
			General_Char_Set();
		}

		private void KEY_SpaceKey_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 44;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Space";
			General_Char_Set();
		}

		private void KEY_SubSub_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 45;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "￣－";
			General_Char_Set();
		}

		private void KEY_ADDADD_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 46;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "+=";
			General_Char_Set();
		}

		private void KEY_LEFT_SQBrace_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 47;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "{[";
			General_Char_Set();
		}

		private void KEY_RIGHT_SQBrace_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 48;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "}]";
			General_Char_Set();
		}

		private void KEY_PIPE_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 49;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "|\\";
			General_Char_Set();
		}

		private void KEY_TILDE_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 53;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "~、";
			General_Char_Set();
		}

		private void KEY_COLON_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 51;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = ":;";
			General_Char_Set();
		}

		private void KEY_QUOTE_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 52;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "\"'";
			General_Char_Set();
		}

		private void KEY_COMMA_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 54;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "<,";
			General_Char_Set();
		}

		private void KEY_PERIOD_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 55;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = ">.";
			General_Char_Set();
		}

		private void KEY_QUESTION_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 56;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "?/";
			General_Char_Set();
		}

		private void KEY_CapsLock_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 57;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "CapsLock";
			General_Char_Set();
		}

		private void KEY_F1_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 58;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F1";
			General_Char_Set();
		}

		private void KEY_F2_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 59;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F2";
			General_Char_Set();
		}

		private void KEY_F3_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 60;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F3";
			General_Char_Set();
		}

		private void KEY_F4_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 61;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F4";
			General_Char_Set();
		}

		private void KEY_F5_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 62;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F5";
			General_Char_Set();
		}

		private void KEY_F6_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 63;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F6";
			General_Char_Set();
		}

		private void KEY_F7_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 64;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F7";
			General_Char_Set();
		}

		private void KEY_F8_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 65;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F8";
			General_Char_Set();
		}

		private void KEY_F9_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 66;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F9";
			General_Char_Set();
		}

		private void KEY_F10_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 67;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F10";
			General_Char_Set();
		}

		private void KEY_F11_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 68;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F11";
			General_Char_Set();
		}

		private void KEY_F12_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 69;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "F12";
			General_Char_Set();
		}

		private void KEY_PrtSc_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 70;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "PrtSc";
			General_Char_Set();
		}

		private void KEY_ScrollLock_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 71;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "ScLock";
			General_Char_Set();
		}

		private void KEY_PauseBreak_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 72;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "PaBk";
			General_Char_Set();
		}

		private void KEY_INS_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 73;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Ins";
			General_Char_Set();
		}

		private void KEY_HOME_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 74;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Home";
			General_Char_Set();
		}

		private void KEY_PgUP_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 75;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "PageUp";
			General_Char_Set();
		}

		private void KEY_DEL_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 76;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "Delete";
			General_Char_Set();
		}

		private void KEY_End_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 77;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "End";
			General_Char_Set();
		}

		private void KEY_PgDN_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 78;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "PageDown";
			General_Char_Set();
		}

		private void KEY_Arrow_right_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 79;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "→";
			General_Char_Set();
		}

		private void KEY_Arrow_left_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 80;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "←";
			General_Char_Set();
		}

		private void KEY_Arrow_Down_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 81;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "↓";
			General_Char_Set();
		}

		private void KEY_Arrow_Up_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 82;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "↑";
			General_Char_Set();
		}

		private void KEY_NUM_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 83;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "NumLock";
			General_Char_Set();
		}

		private void KEY_DIV_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 84;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "÷";
			General_Char_Set();
		}

		private void KEY_multiply_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 85;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "×";
			General_Char_Set();
		}

		private void KEY_sub_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 86;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "－";
			General_Char_Set();
		}

		private void KEY_add_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 87;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "＋";
			General_Char_Set();
		}

		private void KEY_MIN_1_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 89;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "1";
			General_Char_Set();
		}

		private void KEY_MIN_2_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 90;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "2";
			General_Char_Set();
		}

		private void KEY_MIN_3_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 91;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "3";
			General_Char_Set();
		}

		private void KEY_MIN_4_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 92;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "4";
			General_Char_Set();
		}

		private void KEY_MIN_5_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 93;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "5";
			General_Char_Set();
		}

		private void KEY_MIN_6_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 94;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "6";
			General_Char_Set();
		}

		private void KEY_MIN_7_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 95;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "7";
			General_Char_Set();
		}

		private void KEY_MIN_8_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 96;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "8";
			General_Char_Set();
		}

		private void KEY_MIN_9_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 97;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "9";
			General_Char_Set();
		}

		private void KEY_MIN_0_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 98;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "0";
			General_Char_Set();
		}

		private void KEY_MIN_Dot_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 99;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "▪";
			General_Char_Set();
		}

		private void KEY_Menu_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 101;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = "▤";
			General_Char_Set();
		}

		private void Key_Ctrl_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 1;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Ctrl";
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 1;
			++FormMain.KeyParam.ComboKey_Char_Num;
		}

		private void Key_Shift_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 2;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Shift";
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 1;
			++FormMain.KeyParam.ComboKey_Char_Num;
		}

		private void Key_Alt_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 4;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Alt";
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 1;
			++FormMain.KeyParam.ComboKey_Char_Num;
		}

		private void Key_Win_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 8;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Win";
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 1;
			++FormMain.KeyParam.ComboKey_Char_Num;
		}

		#endregion

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			KEY_A = new Button();
			KEY_B = new Button();
			KEY_C = new Button();
			KEY_D = new Button();
			KEY_E = new Button();
			KEY_F = new Button();
			KEY_G = new Button();
			KEY_H = new Button();
			KEY_I = new Button();
			KEY_J = new Button();
			KEY_K = new Button();
			KEY_L = new Button();
			KEY_M = new Button();
			KEY_N = new Button();
			KEY_O = new Button();
			KEY_P = new Button();
			KEY_Q = new Button();
			KEY_R = new Button();
			KEY_S = new Button();
			KEY_T = new Button();
			KEY_U = new Button();
			KEY_V = new Button();
			KEY_W = new Button();
			KEY_X = new Button();
			KEY_Y = new Button();
			KEY_Z = new Button();

			KEY_0 = new Button();
			KEY_9 = new Button();
			KEY_8 = new Button();
			KEY_7 = new Button();
			KEY_6 = new Button();
			KEY_5 = new Button();
			KEY_4 = new Button();
			KEY_3 = new Button();
			KEY_2 = new Button();
			KEY_1 = new Button();

			KEY_F12 = new Button();
			KEY_F11 = new Button();
			KEY_F10 = new Button();
			KEY_F9 = new Button();
			KEY_F8 = new Button();
			KEY_F7 = new Button();
			KEY_F6 = new Button();
			KEY_F5 = new Button();
			KEY_F4 = new Button();
			KEY_F3 = new Button();
			KEY_F2 = new Button();
			KEY_F1 = new Button();

			KEY_ESC = new Button();
			KEY_PrtSc = new Button();
			KEY_PauseBreak = new Button();
			KEY_INS = new Button();
			KEY_DEL = new Button();
			KEY_HOME = new Button();
			KEY_PgUP = new Button();
			KEY_PgDN = new Button();
			KEY_End = new Button();
			KEY_SubSub = new Button();
			KEY_ADDADD = new Button();
			KEY_BACKSPACE = new Button();
			KEY_TAB = new Button();
			KEY_LEFT_SQBrace = new Button();
			KEY_RIGHT_SQBrace = new Button();
			KEY_PIPE = new Button();
			KEY_COLON = new Button();
			KEY_QUOTE = new Button();
			KEY_Enter = new Button();
			KEY_TILDE = new Button();
			KEY_COMMA = new Button();
			KEY_PERIOD = new Button();
			KEY_QUESTION = new Button();

			KEY_Arrow_left = new Button();
			KEY_Arrow_Up = new Button();
			KEY_Arrow_Down = new Button();
			KEY_Arrow_right = new Button();
			
			KEY_add = new Button();
			KEY_sub = new Button();
			KEY_multiply = new Button();
			KEY_DIV = new Button();
			KEY_NUM = new Button();
			KEY_MIN_0 = new Button();
			KEY_MIN_9 = new Button();
			KEY_MIN_8 = new Button();
			KEY_MIN_7 = new Button();
			KEY_MIN_6 = new Button();
			KEY_MIN_5 = new Button();
			KEY_MIN_4 = new Button();
			KEY_MIN_3 = new Button();
			KEY_MIN_2 = new Button();
			KEY_MIN_1 = new Button();
			KEY_MIN_Dot = new Button();

			KEY_CapsLock = new Button();
			KEY_SpaceKey = new Button();
			KEY_ScrollLock = new Button();
			KEY_Menu = new Button();
			Key_Ctrl = new Button();
			Key_Shift = new Button();
			Key_Alt = new Button();
			Key_Win = new Button();

			SuspendLayout();

			KEY_A.Location = new Point(4, 94);
			KEY_A.Name = "KEY_A";
			KEY_A.Size = new Size(44, 23);
			KEY_A.TabIndex = 0;
			KEY_A.Text = "A";
			KEY_A.UseVisualStyleBackColor = true;
			KEY_A.Click += new EventHandler(KEY_A_Click);
			KEY_B.Location = new Point(54, 94);
			KEY_B.Name = "KEY_B";
			KEY_B.Size = new Size(45, 23);
			KEY_B.TabIndex = 1;
			KEY_B.Text = "B";
			KEY_B.UseVisualStyleBackColor = true;
			KEY_B.Click += new EventHandler(KEY_B_Click);
			KEY_C.Location = new Point(105, 94);
			KEY_C.Name = "KEY_C";
			KEY_C.Size = new Size(45, 23);
			KEY_C.TabIndex = 2;
			KEY_C.Text = "C";
			KEY_C.UseVisualStyleBackColor = true;
			KEY_C.Click += new EventHandler(KEY_C_Click);
			KEY_D.Location = new Point(156, 94);
			KEY_D.Name = "KEY_D";
			KEY_D.Size = new Size(45, 23);
			KEY_D.TabIndex = 3;
			KEY_D.Text = "D";
			KEY_D.UseVisualStyleBackColor = true;
			KEY_D.Click += new EventHandler(KEY_D_Click);
			KEY_E.Location = new Point(207, 94);
			KEY_E.Name = "KEY_E";
			KEY_E.Size = new Size(45, 23);
			KEY_E.TabIndex = 4;
			KEY_E.Text = "E";
			KEY_E.UseVisualStyleBackColor = true;
			KEY_E.Click += new EventHandler(KEY_E_Click);
			KEY_F.Location = new Point(258, 94);
			KEY_F.Name = "KEY_F";
			KEY_F.Size = new Size(45, 23);
			KEY_F.TabIndex = 5;
			KEY_F.Text = "F";
			KEY_F.UseVisualStyleBackColor = true;
			KEY_F.Click += new EventHandler(KEY_F_Click);
			KEY_G.Location = new Point(309, 94);
			KEY_G.Name = "KEY_G";
			KEY_G.Size = new Size(45, 23);
			KEY_G.TabIndex = 7;
			KEY_G.Text = "G";
			KEY_G.UseVisualStyleBackColor = true;
			KEY_G.Click += new EventHandler(KEY_G_Click);
			KEY_H.Location = new Point(360, 94);
			KEY_H.Name = "KEY_H";
			KEY_H.Size = new Size(45, 23);
			KEY_H.TabIndex = 8;
			KEY_H.Text = "H";
			KEY_H.UseVisualStyleBackColor = true;
			KEY_H.Click += new EventHandler(KEY_H_Click);
			KEY_I.Location = new Point(411, 94);
			KEY_I.Name = "KEY_I";
			KEY_I.Size = new Size(45, 23);
			KEY_I.TabIndex = 9;
			KEY_I.Text = "I";
			KEY_I.UseVisualStyleBackColor = true;
			KEY_I.Click += new EventHandler(KEY_I_Click);
			KEY_J.Location = new Point(462, 94);
			KEY_J.Name = "KEY_J";
			KEY_J.Size = new Size(45, 23);
			KEY_J.TabIndex = 10;
			KEY_J.Text = "J";
			KEY_J.UseVisualStyleBackColor = true;
			KEY_J.Click += new EventHandler(KEY_J_Click);
			KEY_K.Location = new Point(513, 94);
			KEY_K.Name = "KEY_K";
			KEY_K.Size = new Size(45, 23);
			KEY_K.TabIndex = 11;
			KEY_K.Text = "K";
			KEY_K.UseVisualStyleBackColor = true;
			KEY_K.Click += new EventHandler(KEY_K_Click);
			KEY_L.Location = new Point(565, 94);
			KEY_L.Name = "KEY_L";
			KEY_L.Size = new Size(44, 23);
			KEY_L.TabIndex = 12;
			KEY_L.Text = "L";
			KEY_L.UseVisualStyleBackColor = true;
			KEY_L.Click += new EventHandler(KEY_L_Click);
			KEY_M.Location = new Point(616, 94);
			KEY_M.Name = "KEY_M";
			KEY_M.Size = new Size(46, 23);
			KEY_M.TabIndex = 13;
			KEY_M.Text = "M";
			KEY_M.UseVisualStyleBackColor = true;
			KEY_M.Click += new EventHandler(KEY_M_Click);
			KEY_N.Location = new Point(5, 123);
			KEY_N.Name = "KEY_N";
			KEY_N.Size = new Size(45, 23);
			KEY_N.TabIndex = 14;
			KEY_N.Text = "N";
			KEY_N.UseVisualStyleBackColor = true;
			KEY_N.Click += new EventHandler(KEY_N_Click);
			KEY_O.Location = new Point(56, 123);
			KEY_O.Name = "KEY_O";
			KEY_O.Size = new Size(45, 23);
			KEY_O.TabIndex = 15;
			KEY_O.Text = "O";
			KEY_O.UseVisualStyleBackColor = true;
			KEY_O.Click += new EventHandler(KEY_O_Click);
			KEY_P.Location = new Point(105, 123);
			KEY_P.Name = "KEY_P";
			KEY_P.Size = new Size(47, 23);
			KEY_P.TabIndex = 16;
			KEY_P.Text = "P";
			KEY_P.UseVisualStyleBackColor = true;
			KEY_P.Click += new EventHandler(KEY_P_Click);
			KEY_Q.Location = new Point(158, 123);
			KEY_Q.Name = "KEY_Q";
			KEY_Q.Size = new Size(45, 23);
			KEY_Q.TabIndex = 17;
			KEY_Q.Text = "Q";
			KEY_Q.UseVisualStyleBackColor = true;
			KEY_Q.Click += new EventHandler(KEY_Q_Click);
			KEY_R.Location = new Point(209, 123);
			KEY_R.Name = "KEY_R";
			KEY_R.Size = new Size(45, 23);
			KEY_R.TabIndex = 18;
			KEY_R.Text = "R";
			KEY_R.UseVisualStyleBackColor = true;
			KEY_R.Click += new EventHandler(KEY_R_Click);
			KEY_S.Location = new Point(260, 123);
			KEY_S.Name = "KEY_S";
			KEY_S.Size = new Size(45, 23);
			KEY_S.TabIndex = 19;
			KEY_S.Text = "S";
			KEY_S.UseVisualStyleBackColor = true;
			KEY_S.Click += new EventHandler(KEY_S_Click);
			KEY_T.Location = new Point(309, 123);
			KEY_T.Name = "KEY_T";
			KEY_T.Size = new Size(47, 23);
			KEY_T.TabIndex = 20;
			KEY_T.Text = "T";
			KEY_T.UseVisualStyleBackColor = true;
			KEY_T.Click += new EventHandler(KEY_T_Click);
			KEY_U.Location = new Point(362, 123);
			KEY_U.Name = "KEY_U";
			KEY_U.Size = new Size(45, 23);
			KEY_U.TabIndex = 21;
			KEY_U.Text = "U";
			KEY_U.UseVisualStyleBackColor = true;
			KEY_U.Click += new EventHandler(KEY_U_Click);
			KEY_V.Location = new Point(413, 123);
			KEY_V.Name = "KEY_V";
			KEY_V.Size = new Size(45, 23);
			KEY_V.TabIndex = 22;
			KEY_V.Text = "V";
			KEY_V.UseVisualStyleBackColor = true;
			KEY_V.Click += new EventHandler(KEY_V_Click);
			KEY_W.Location = new Point(464, 123);
			KEY_W.Name = "KEY_W";
			KEY_W.Size = new Size(45, 23);
			KEY_W.TabIndex = 23;
			KEY_W.Text = "W";
			KEY_W.UseVisualStyleBackColor = true;
			KEY_W.Click += new EventHandler(KEY_W_Click);
			KEY_X.Location = new Point(515, 123);
			KEY_X.Name = "KEY_X";
			KEY_X.Size = new Size(44, 23);
			KEY_X.TabIndex = 24;
			KEY_X.Text = "X";
			KEY_X.UseVisualStyleBackColor = true;
			KEY_X.Click += new EventHandler(KEY_X_Click);
			KEY_Y.Location = new Point(565, 123);
			KEY_Y.Name = "KEY_Y";
			KEY_Y.Size = new Size(45, 23);
			KEY_Y.TabIndex = 25;
			KEY_Y.Text = "Y";
			KEY_Y.UseVisualStyleBackColor = true;
			KEY_Y.Click += new EventHandler(KEY_Y_Click);
			KEY_Z.Location = new Point(615, 123);
			KEY_Z.Name = "KEY_Z";
			KEY_Z.Size = new Size(47, 23);
			KEY_Z.TabIndex = 26;
			KEY_Z.Text = "Z";
			KEY_Z.UseVisualStyleBackColor = true;
			KEY_Z.Click += new EventHandler(KEY_Z_Click);

			KEY_0.Location = new Point(512, 65);
			KEY_0.Name = "KEY_0";
			KEY_0.Size = new Size(45, 23);
			KEY_0.TabIndex = 36;
			KEY_0.Text = ") 0";
			KEY_0.UseVisualStyleBackColor = true;
			KEY_0.Click += new EventHandler(KEY_0_Click);
			KEY_9.Location = new Point(462, 65);
			KEY_9.Name = "KEY_9";
			KEY_9.Size = new Size(45, 23);
			KEY_9.TabIndex = 27;
			KEY_9.Text = "( 9";
			KEY_9.UseVisualStyleBackColor = true;
			KEY_9.Click += new EventHandler(KEY_9_Click);
			KEY_8.Location = new Point(411, 65);
			KEY_8.Name = "KEY_8";
			KEY_8.Size = new Size(45, 23);
			KEY_8.TabIndex = 35;
			KEY_8.Text = "* 8";
			KEY_8.UseVisualStyleBackColor = true;
			KEY_8.Click += new EventHandler(KEY_8_Click);
			KEY_7.Location = new Point(360, 65);
			KEY_7.Name = "KEY_7";
			KEY_7.Size = new Size(45, 23);
			KEY_7.TabIndex = 34;
			KEY_7.Text = "＆ 7";
			KEY_7.UseVisualStyleBackColor = true;
			KEY_7.Click += new EventHandler(KEY_7_Click);
			KEY_6.Location = new Point(309, 65);
			KEY_6.Name = "KEY_6";
			KEY_6.Size = new Size(45, 23);
			KEY_6.TabIndex = 33;
			KEY_6.Text = "^ 6";
			KEY_6.UseVisualStyleBackColor = true;
			KEY_6.Click += new EventHandler(KEY_6_Click);
			KEY_5.Location = new Point(258, 65);
			KEY_5.Name = "KEY_5";
			KEY_5.Size = new Size(45, 23);
			KEY_5.TabIndex = 32;
			KEY_5.Text = "% 5";
			KEY_5.UseVisualStyleBackColor = true;
			KEY_5.Click += new EventHandler(KEY_5_Click);
			KEY_4.Location = new Point(207, 65);
			KEY_4.Name = "KEY_4";
			KEY_4.Size = new Size(45, 23);
			KEY_4.TabIndex = 31;
			KEY_4.Text = "$ 4";
			KEY_4.UseVisualStyleBackColor = true;
			KEY_4.Click += new EventHandler(KEY_4_Click);
			KEY_3.Location = new Point(156, 65);
			KEY_3.Name = "KEY_3";
			KEY_3.Size = new Size(45, 23);
			KEY_3.TabIndex = 30;
			KEY_3.Text = "# 3";
			KEY_3.UseVisualStyleBackColor = true;
			KEY_3.Click += new EventHandler(KEY_3_Click);
			KEY_2.Location = new Point(105, 65);
			KEY_2.Name = "KEY_2";
			KEY_2.Size = new Size(45, 23);
			KEY_2.TabIndex = 29;
			KEY_2.Text = "@ 2";
			KEY_2.UseVisualStyleBackColor = true;
			KEY_2.Click += new EventHandler(KEY_2_Click);
			KEY_1.Location = new Point(54, 65);
			KEY_1.Name = "KEY_1";
			KEY_1.Size = new Size(45, 23);
			KEY_1.TabIndex = 28;
			KEY_1.Text = "! 1";
			KEY_1.UseVisualStyleBackColor = true;
			KEY_1.Click += new EventHandler(KEY_1_Click);

			KEY_F12.Location = new Point(617, 7);
			KEY_F12.Name = "KEY_F12";
			KEY_F12.Size = new Size(44, 23);
			KEY_F12.TabIndex = 48;
			KEY_F12.Text = "F12";
			KEY_F12.UseVisualStyleBackColor = true;
			KEY_F12.Click += new EventHandler(KEY_F12_Click);
			KEY_F11.Location = new Point(566, 7);
			KEY_F11.Name = "KEY_F11";
			KEY_F11.Size = new Size(45, 23);
			KEY_F11.TabIndex = 47;
			KEY_F11.Text = "F11";
			KEY_F11.UseVisualStyleBackColor = true;
			KEY_F11.Click += new EventHandler(KEY_F11_Click);
			KEY_F10.Location = new Point(515, 7);
			KEY_F10.Name = "KEY_F10";
			KEY_F10.Size = new Size(45, 23);
			KEY_F10.TabIndex = 46;
			KEY_F10.Text = "F10";
			KEY_F10.UseVisualStyleBackColor = true;
			KEY_F10.Click += new EventHandler(KEY_F10_Click);
			KEY_F9.Location = new Point(464, 7);
			KEY_F9.Name = "KEY_F9";
			KEY_F9.Size = new Size(45, 23);
			KEY_F9.TabIndex = 45;
			KEY_F9.Text = "F9";
			KEY_F9.UseVisualStyleBackColor = true;
			KEY_F9.Click += new EventHandler(KEY_F9_Click);
			KEY_F8.Location = new Point(413, 7);
			KEY_F8.Name = "KEY_F8";
			KEY_F8.Size = new Size(45, 23);
			KEY_F8.TabIndex = 44;
			KEY_F8.Text = "F8";
			KEY_F8.UseVisualStyleBackColor = true;
			KEY_F8.Click += new EventHandler(KEY_F8_Click);
			KEY_F7.Location = new Point(362, 7);
			KEY_F7.Name = "KEY_F7";
			KEY_F7.Size = new Size(45, 23);
			KEY_F7.TabIndex = 43;
			KEY_F7.Text = "F7";
			KEY_F7.UseVisualStyleBackColor = true;
			KEY_F7.Click += new EventHandler(KEY_F7_Click);
			KEY_F6.Location = new Point(311, 7);
			KEY_F6.Name = "KEY_F6";
			KEY_F6.Size = new Size(45, 23);
			KEY_F6.TabIndex = 42;
			KEY_F6.Text = "F6";
			KEY_F6.UseVisualStyleBackColor = true;
			KEY_F6.Click += new EventHandler(KEY_F6_Click);
			KEY_F5.Location = new Point(260, 7);
			KEY_F5.Name = "KEY_F5";
			KEY_F5.Size = new Size(45, 23);
			KEY_F5.TabIndex = 41;
			KEY_F5.Text = "F5";
			KEY_F5.UseVisualStyleBackColor = true;
			KEY_F5.Click += new EventHandler(KEY_F5_Click);
			KEY_F4.Location = new Point(209, 7);
			KEY_F4.Name = "KEY_F4";
			KEY_F4.Size = new Size(45, 23);
			KEY_F4.TabIndex = 40;
			KEY_F4.Text = "F4";
			KEY_F4.UseVisualStyleBackColor = true;
			KEY_F4.Click += new EventHandler(KEY_F4_Click);
			KEY_F3.Location = new Point(158, 7);
			KEY_F3.Name = "KEY_F3";
			KEY_F3.Size = new Size(45, 23);
			KEY_F3.TabIndex = 39;
			KEY_F3.Text = "F3";
			KEY_F3.UseVisualStyleBackColor = true;
			KEY_F3.Click += new EventHandler(KEY_F3_Click);
			KEY_F2.Location = new Point(107, 7);
			KEY_F2.Name = "KEY_F2";
			KEY_F2.Size = new Size(45, 23);
			KEY_F2.TabIndex = 38;
			KEY_F2.Text = "F2";
			KEY_F2.UseVisualStyleBackColor = true;
			KEY_F2.Click += new EventHandler(KEY_F2_Click);
			KEY_F1.Location = new Point(56, 5);
			KEY_F1.Name = "KEY_F1";
			KEY_F1.Size = new Size(45, 23);
			KEY_F1.TabIndex = 37;
			KEY_F1.Text = "F1";
			KEY_F1.UseVisualStyleBackColor = true;
			KEY_F1.Click += new EventHandler(KEY_F1_Click);

			KEY_ESC.Location = new Point(4, 5);
			KEY_ESC.Name = "KEY_ESC";
			KEY_ESC.Size = new Size(45, 23);
			KEY_ESC.TabIndex = 49;
			KEY_ESC.Text = "ESC";
			KEY_ESC.UseVisualStyleBackColor = true;
			KEY_ESC.Click += new EventHandler(KEY_ESC_Click);
			KEY_PrtSc.Location = new Point(4, 36);
			KEY_PrtSc.Name = "KEY_PrtSc";
			KEY_PrtSc.Size = new Size(76, 23);
			KEY_PrtSc.TabIndex = 50;
			KEY_PrtSc.Text = "PrtScSysRq";
			KEY_PrtSc.UseVisualStyleBackColor = true;
			KEY_PrtSc.Click += new EventHandler(KEY_PrtSc_Click);
			KEY_PauseBreak.Location = new Point(173, 36);
			KEY_PauseBreak.Name = "KEY_PauseBreak";
			KEY_PauseBreak.Size = new Size(90, 23);
			KEY_PauseBreak.TabIndex = 51;
			KEY_PauseBreak.Text = "PauseBreak";
			KEY_PauseBreak.UseVisualStyleBackColor = true;
			KEY_PauseBreak.Click += new EventHandler(KEY_PauseBreak_Click);
			KEY_INS.Location = new Point(269, 36);
			KEY_INS.Name = "KEY_INS";
			KEY_INS.Size = new Size(54, 23);
			KEY_INS.TabIndex = 52;
			KEY_INS.Text = "Insert";
			KEY_INS.UseVisualStyleBackColor = true;
			KEY_INS.Click += new EventHandler(KEY_INS_Click);
			KEY_DEL.Location = new Point(329, 36);
			KEY_DEL.Name = "KEY_DEL";
			KEY_DEL.Size = new Size(63, 23);
			KEY_DEL.TabIndex = 53;
			KEY_DEL.Text = "Delete";
			KEY_DEL.UseVisualStyleBackColor = true;
			KEY_DEL.Click += new EventHandler(KEY_DEL_Click);
			KEY_HOME.Location = new Point(398, 36);
			KEY_HOME.Name = "KEY_HOME";
			KEY_HOME.Size = new Size(58, 23);
			KEY_HOME.TabIndex = 54;
			KEY_HOME.Text = "Home";
			KEY_HOME.UseVisualStyleBackColor = true;
			KEY_HOME.Click += new EventHandler(KEY_HOME_Click);
			KEY_PgUP.Location = new Point(462, 36);
			KEY_PgUP.Name = "KEY_PgUP";
			KEY_PgUP.Size = new Size(62, 23);
			KEY_PgUP.TabIndex = 56;
			KEY_PgUP.Text = "Page Up";
			KEY_PgUP.UseVisualStyleBackColor = true;
			KEY_PgUP.Click += new EventHandler(KEY_PgUP_Click);
			KEY_PgDN.Location = new Point(532, 36);
			KEY_PgDN.Name = "KEY_PgDN";
			KEY_PgDN.Size = new Size(70, 23);
			KEY_PgDN.TabIndex = 57;
			KEY_PgDN.Text = "Page Down";
			KEY_PgDN.UseVisualStyleBackColor = true;
			KEY_PgDN.Click += new EventHandler(KEY_PgDN_Click);
			KEY_End.Location = new Point(608, 36);
			KEY_End.Name = "KEY_End";
			KEY_End.Size = new Size(53, 23);
			KEY_End.TabIndex = 58;
			KEY_End.Text = "End";
			KEY_End.UseVisualStyleBackColor = true;
			KEY_End.Click += new EventHandler(KEY_End_Click);
			KEY_SubSub.Location = new Point(565, 65);
			KEY_SubSub.Name = "KEY_SubSub";
			KEY_SubSub.Size = new Size(45, 23);
			KEY_SubSub.TabIndex = 59;
			KEY_SubSub.Text = "￣－";
			KEY_SubSub.UseVisualStyleBackColor = true;
			KEY_SubSub.Click += new EventHandler(KEY_SubSub_Click);
			KEY_ADDADD.Location = new Point(617, 65);
			KEY_ADDADD.Name = "KEY_ADDADD";
			KEY_ADDADD.Size = new Size(45, 23);
			KEY_ADDADD.TabIndex = 60;
			KEY_ADDADD.Text = "＋=";
			KEY_ADDADD.UseVisualStyleBackColor = true;
			KEY_ADDADD.Click += new EventHandler(KEY_ADDADD_Click);
			KEY_BACKSPACE.Location = new Point(372, 181);
			KEY_BACKSPACE.Name = "KEY_BACKSPACE";
			KEY_BACKSPACE.Size = new Size(92, 23);
			KEY_BACKSPACE.TabIndex = 61;
			KEY_BACKSPACE.Text = "← Backspace";
			KEY_BACKSPACE.UseVisualStyleBackColor = true;
			KEY_BACKSPACE.Click += new EventHandler(KEY_BACKSPACE_Click);
			KEY_TAB.Location = new Point(4, 152);
			KEY_TAB.Name = "KEY_TAB";
			KEY_TAB.Size = new Size(97, 23);
			KEY_TAB.TabIndex = 62;
			KEY_TAB.Text = "Tab";
			KEY_TAB.UseVisualStyleBackColor = true;
			KEY_TAB.Click += new EventHandler(KEY_TAB_Click);
			KEY_LEFT_SQBrace.Location = new Point(309, 152);
			KEY_LEFT_SQBrace.Name = "KEY_LEFT_SQBrace";
			KEY_LEFT_SQBrace.Size = new Size(45, 23);
			KEY_LEFT_SQBrace.TabIndex = 63;
			KEY_LEFT_SQBrace.Text = "{ [";
			KEY_LEFT_SQBrace.UseVisualStyleBackColor = true;
			KEY_LEFT_SQBrace.Click += new EventHandler(KEY_LEFT_SQBrace_Click);
			KEY_RIGHT_SQBrace.Location = new Point(362, 152);
			KEY_RIGHT_SQBrace.Name = "KEY_RIGHT_SQBrace";
			KEY_RIGHT_SQBrace.Size = new Size(45, 23);
			KEY_RIGHT_SQBrace.TabIndex = 64;
			KEY_RIGHT_SQBrace.Text = "} ]";
			KEY_RIGHT_SQBrace.UseVisualStyleBackColor = true;
			KEY_RIGHT_SQBrace.Click += new EventHandler(KEY_RIGHT_SQBrace_Click);
			KEY_PIPE.Location = new Point(413, 152);
			KEY_PIPE.Name = "KEY_PIPE";
			KEY_PIPE.Size = new Size(45, 23);
			KEY_PIPE.TabIndex = 65;
			KEY_PIPE.Text = "| \\";
			KEY_PIPE.UseVisualStyleBackColor = true;
			KEY_PIPE.Click += new EventHandler(KEY_PIPE_Click);
			KEY_COLON.Location = new Point(464, 152);
			KEY_COLON.Name = "KEY_COLON";
			KEY_COLON.Size = new Size(45, 23);
			KEY_COLON.TabIndex = 66;
			KEY_COLON.Text = "： ；";
			KEY_COLON.UseVisualStyleBackColor = true;
			KEY_COLON.Click += new EventHandler(KEY_COLON_Click);
			KEY_QUOTE.Location = new Point(513, 152);
			KEY_QUOTE.Name = "KEY_QUOTE";
			KEY_QUOTE.Size = new Size(45, 23);
			KEY_QUOTE.TabIndex = 67;
			KEY_QUOTE.Text = "＂ ＇";
			KEY_QUOTE.UseVisualStyleBackColor = true;
			KEY_QUOTE.Click += new EventHandler(KEY_QUOTE_Click);
			KEY_Enter.Location = new Point(209, 152);
			KEY_Enter.Name = "KEY_Enter";
			KEY_Enter.Size = new Size(94, 23);
			KEY_Enter.TabIndex = 68;
			KEY_Enter.Text = "Enter";
			KEY_Enter.UseVisualStyleBackColor = true;
			KEY_Enter.Click += new EventHandler(KEY_Enter_Click);
			KEY_TILDE.Location = new Point(4, 65);
			KEY_TILDE.Name = "KEY_TILDE";
			KEY_TILDE.Size = new Size(45, 23);
			KEY_TILDE.TabIndex = 69;
			KEY_TILDE.Text = "~ 、";
			KEY_TILDE.UseVisualStyleBackColor = true;
			KEY_TILDE.Click += new EventHandler(KEY_TILDE_Click);
			KEY_COMMA.Location = new Point(564, 152);
			KEY_COMMA.Name = "KEY_COMMA";
			KEY_COMMA.Size = new Size(47, 23);
			KEY_COMMA.TabIndex = 70;
			KEY_COMMA.Text = "＜ ，";
			KEY_COMMA.UseVisualStyleBackColor = true;
			KEY_COMMA.Click += new EventHandler(KEY_COMMA_Click);
			KEY_PERIOD.Location = new Point(616, 152);
			KEY_PERIOD.Name = "KEY_PERIOD";
			KEY_PERIOD.Size = new Size(46, 23);
			KEY_PERIOD.TabIndex = 71;
			KEY_PERIOD.Text = "＞ .";
			KEY_PERIOD.UseVisualStyleBackColor = true;
			KEY_PERIOD.Click += new EventHandler(KEY_PERIOD_Click);
			KEY_QUESTION.Location = new Point(667, 152);
			KEY_QUESTION.Name = "KEY_QUESTION";
			KEY_QUESTION.Size = new Size(45, 23);
			KEY_QUESTION.TabIndex = 72;
			KEY_QUESTION.Text = "?  /";
			KEY_QUESTION.UseVisualStyleBackColor = true;
			KEY_QUESTION.Click += new EventHandler(KEY_QUESTION_Click);

			KEY_Arrow_left.Location = new Point(667, 7);
			KEY_Arrow_left.Name = "KEY_Arrow_left";
			KEY_Arrow_left.Size = new Size(45, 23);
			KEY_Arrow_left.TabIndex = 73;
			KEY_Arrow_left.Text = "←";
			KEY_Arrow_left.UseVisualStyleBackColor = true;
			KEY_Arrow_left.Click += new EventHandler(KEY_Arrow_left_Click);
			KEY_Arrow_Up.Location = new Point(668, 65);
			KEY_Arrow_Up.Name = "KEY_Arrow_Up";
			KEY_Arrow_Up.Size = new Size(45, 23);
			KEY_Arrow_Up.TabIndex = 74;
			KEY_Arrow_Up.Text = "↑";
			KEY_Arrow_Up.UseVisualStyleBackColor = true;
			KEY_Arrow_Up.Click += new EventHandler(KEY_Arrow_Up_Click);
			KEY_Arrow_Down.Location = new Point(668, 94);
			KEY_Arrow_Down.Name = "KEY_Arrow_Down";
			KEY_Arrow_Down.Size = new Size(45, 23);
			KEY_Arrow_Down.TabIndex = 75;
			KEY_Arrow_Down.Text = "↓";
			KEY_Arrow_Down.UseVisualStyleBackColor = true;
			KEY_Arrow_Down.Click += new EventHandler(KEY_Arrow_Down_Click);
			KEY_Arrow_right.Location = new Point(668, 36);
			KEY_Arrow_right.Name = "KEY_Arrow_right";
			KEY_Arrow_right.Size = new Size(45, 23);
			KEY_Arrow_right.TabIndex = 76;
			KEY_Arrow_right.Text = "→";
			KEY_Arrow_right.UseVisualStyleBackColor = true;
			KEY_Arrow_right.Click += new EventHandler(KEY_Arrow_right_Click);

			KEY_add.Location = new Point(470, 181);
			KEY_add.Name = "KEY_add";
			KEY_add.Size = new Size(62, 23);
			KEY_add.TabIndex = 77;
			KEY_add.Text = "＋";
			KEY_add.UseVisualStyleBackColor = true;
			KEY_add.Click += new EventHandler(KEY_add_Click);
			KEY_sub.Location = new Point(538, 181);
			KEY_sub.Name = "KEY_sub";
			KEY_sub.Size = new Size(53, 23);
			KEY_sub.TabIndex = 78;
			KEY_sub.Text = "－";
			KEY_sub.UseVisualStyleBackColor = true;
			KEY_sub.Click += new EventHandler(KEY_sub_Click);
			KEY_multiply.Location = new Point(597, 181);
			KEY_multiply.Name = "KEY_multiply";
			KEY_multiply.Size = new Size(54, 23);
			KEY_multiply.TabIndex = 79;
			KEY_multiply.Text = "×";
			KEY_multiply.UseVisualStyleBackColor = true;
			KEY_multiply.Click += new EventHandler(KEY_multiply_Click);
			KEY_DIV.Location = new Point(657, 181);
			KEY_DIV.Name = "KEY_DIV";
			KEY_DIV.Size = new Size(55, 23);
			KEY_DIV.TabIndex = 80;
			KEY_DIV.Text = "÷";
			KEY_DIV.UseVisualStyleBackColor = true;
			KEY_DIV.Click += new EventHandler(KEY_DIV_Click);
			KEY_NUM.Location = new Point(5, 210);
			KEY_NUM.Name = "KEY_NUM";
			KEY_NUM.Size = new Size(95, 23);
			KEY_NUM.TabIndex = 91;
			KEY_NUM.Text = "NumLock";
			KEY_NUM.UseVisualStyleBackColor = true;
			KEY_NUM.Click += new EventHandler(KEY_NUM_Click);
			KEY_MIN_0.Location = new Point(564, 210);
			KEY_MIN_0.Name = "KEY_MIN_0";
			KEY_MIN_0.Size = new Size(45, 23);
			KEY_MIN_0.TabIndex = 90;
			KEY_MIN_0.Text = "0";
			KEY_MIN_0.UseVisualStyleBackColor = true;
			KEY_MIN_0.Click += new EventHandler(KEY_MIN_0_Click);
			KEY_MIN_9.Location = new Point(513, 210);
			KEY_MIN_9.Name = "KEY_MIN_9";
			KEY_MIN_9.Size = new Size(45, 23);
			KEY_MIN_9.TabIndex = 89;
			KEY_MIN_9.Text = "9";
			KEY_MIN_9.UseVisualStyleBackColor = true;
			KEY_MIN_9.Click += new EventHandler(KEY_MIN_9_Click);
			KEY_MIN_8.Location = new Point(462, 210);
			KEY_MIN_8.Name = "KEY_MIN_8";
			KEY_MIN_8.Size = new Size(45, 23);
			KEY_MIN_8.TabIndex = 88;
			KEY_MIN_8.Text = "8";
			KEY_MIN_8.UseVisualStyleBackColor = true;
			KEY_MIN_8.Click += new EventHandler(KEY_MIN_8_Click);
			KEY_MIN_7.Location = new Point(411, 210);
			KEY_MIN_7.Name = "KEY_MIN_7";
			KEY_MIN_7.Size = new Size(45, 23);
			KEY_MIN_7.TabIndex = 87;
			KEY_MIN_7.Text = "7";
			KEY_MIN_7.UseVisualStyleBackColor = true;
			KEY_MIN_7.Click += new EventHandler(KEY_MIN_7_Click);
			KEY_MIN_6.Location = new Point(360, 210);
			KEY_MIN_6.Name = "KEY_MIN_6";
			KEY_MIN_6.Size = new Size(45, 23);
			KEY_MIN_6.TabIndex = 86;
			KEY_MIN_6.Text = "6";
			KEY_MIN_6.UseVisualStyleBackColor = true;
			KEY_MIN_6.Click += new EventHandler(KEY_MIN_6_Click);
			KEY_MIN_5.Location = new Point(309, 210);
			KEY_MIN_5.Name = "KEY_MIN_5";
			KEY_MIN_5.Size = new Size(45, 23);
			KEY_MIN_5.TabIndex = 85;
			KEY_MIN_5.Text = "5";
			KEY_MIN_5.UseVisualStyleBackColor = true;
			KEY_MIN_5.Click += new EventHandler(KEY_MIN_5_Click);
			KEY_MIN_4.Location = new Point(258, 210);
			KEY_MIN_4.Name = "KEY_MIN_4";
			KEY_MIN_4.Size = new Size(45, 23);
			KEY_MIN_4.TabIndex = 84;
			KEY_MIN_4.Text = "4";
			KEY_MIN_4.UseVisualStyleBackColor = true;
			KEY_MIN_4.Click += new EventHandler(KEY_MIN_4_Click);
			KEY_MIN_3.Location = new Point(207, 210);
			KEY_MIN_3.Name = "KEY_MIN_3";
			KEY_MIN_3.Size = new Size(45, 23);
			KEY_MIN_3.TabIndex = 83;
			KEY_MIN_3.Text = "3";
			KEY_MIN_3.UseVisualStyleBackColor = true;
			KEY_MIN_3.Click += new EventHandler(KEY_MIN_3_Click);
			KEY_MIN_2.Location = new Point(156, 210);
			KEY_MIN_2.Name = "KEY_MIN_2";
			KEY_MIN_2.Size = new Size(45, 23);
			KEY_MIN_2.TabIndex = 82;
			KEY_MIN_2.Text = "2";
			KEY_MIN_2.UseVisualStyleBackColor = true;
			KEY_MIN_2.Click += new EventHandler(KEY_MIN_2_Click);
			KEY_MIN_1.Location = new Point(106, 210);
			KEY_MIN_1.Name = "KEY_MIN_1";
			KEY_MIN_1.Size = new Size(44, 23);
			KEY_MIN_1.TabIndex = 81;
			KEY_MIN_1.Text = "1";
			KEY_MIN_1.UseVisualStyleBackColor = true;
			KEY_MIN_1.Click += new EventHandler(KEY_MIN_1_Click);
			KEY_MIN_Dot.Location = new Point(614, 210);
			KEY_MIN_Dot.Name = "KEY_MIN_Dot";
			KEY_MIN_Dot.Size = new Size(45, 23);
			KEY_MIN_Dot.TabIndex = 92;
			KEY_MIN_Dot.Text = "·";
			KEY_MIN_Dot.UseVisualStyleBackColor = true;
			KEY_MIN_Dot.Click += new EventHandler(KEY_MIN_Dot_Click);

			KEY_CapsLock.Location = new Point(105, 152);
			KEY_CapsLock.Name = "KEY_CapsLock";
			KEY_CapsLock.Size = new Size(98, 23);
			KEY_CapsLock.TabIndex = 93;
			KEY_CapsLock.Text = "CapsLock";
			KEY_CapsLock.UseVisualStyleBackColor = true;
			KEY_CapsLock.Click += new EventHandler(KEY_CapsLock_Click);
			KEY_SpaceKey.Location = new Point(291, 181);
			KEY_SpaceKey.Name = "KEY_SpaceKey";
			KEY_SpaceKey.Size = new Size(75, 23);
			KEY_SpaceKey.TabIndex = 94;
			KEY_SpaceKey.Text = "Space";
			KEY_SpaceKey.UseVisualStyleBackColor = true;
			KEY_SpaceKey.Click += new EventHandler(KEY_SpaceKey_Click);
			KEY_ScrollLock.Location = new Point(86, 36);
			KEY_ScrollLock.Name = "KEY_ScrollLock";
			KEY_ScrollLock.Size = new Size(81, 23);
			KEY_ScrollLock.TabIndex = 95;
			KEY_ScrollLock.Text = "ScrollLock";
			KEY_ScrollLock.UseVisualStyleBackColor = true;
			KEY_ScrollLock.Click += new EventHandler(KEY_ScrollLock_Click);
			KEY_Menu.Location = new Point(668, 123);
			KEY_Menu.Name = "KEY_Menu";
			KEY_Menu.Size = new Size(44, 23);
			KEY_Menu.TabIndex = 96;
			KEY_Menu.Text = "MENU";
			KEY_Menu.UseVisualStyleBackColor = true;
			KEY_Menu.Click += new EventHandler(KEY_Menu_Click);
			Key_Ctrl.Location = new Point(5, 181);
			Key_Ctrl.Name = "Key_Ctrl";
			Key_Ctrl.Size = new Size(62, 23);
			Key_Ctrl.TabIndex = 97;
			Key_Ctrl.Text = "Ctrl";
			Key_Ctrl.UseVisualStyleBackColor = true;
			Key_Ctrl.Click += new EventHandler(Key_Ctrl_Click);
			Key_Shift.Location = new Point(73, 181);
			Key_Shift.Name = "Key_Shift";
			Key_Shift.Size = new Size(64, 23);
			Key_Shift.TabIndex = 98;
			Key_Shift.Text = "Shift";
			Key_Shift.UseVisualStyleBackColor = true;
			Key_Shift.Click += new EventHandler(Key_Shift_Click);
			Key_Alt.Location = new Point(143, 181);
			Key_Alt.Name = "Key_Alt";
			Key_Alt.Size = new Size(60, 23);
			Key_Alt.TabIndex = 99;
			Key_Alt.Text = "Alt";
			Key_Alt.UseVisualStyleBackColor = true;
			Key_Alt.Click += new EventHandler(Key_Alt_Click);
			Key_Win.Location = new Point(209, 181);
			Key_Win.Name = "Key_Win";
			Key_Win.Size = new Size(76, 23);
			Key_Win.TabIndex = 100;
			Key_Win.Text = "Win";
			Key_Win.UseVisualStyleBackColor = true;
			Key_Win.Click += new EventHandler(Key_Win_Click);

			AutoScaleDimensions = new SizeF(6f, 12f);
			AutoScaleMode = AutoScaleMode.Font;

			Controls.Add(Key_Win);
			Controls.Add(Key_Alt);
			Controls.Add(Key_Shift);
			Controls.Add(Key_Ctrl);
			Controls.Add(KEY_Menu);
			Controls.Add(KEY_ScrollLock);
			Controls.Add(KEY_SpaceKey);
			Controls.Add(KEY_CapsLock);

			Controls.Add(KEY_MIN_Dot);
			Controls.Add(KEY_NUM);
			Controls.Add(KEY_MIN_0);
			Controls.Add(KEY_MIN_9);
			Controls.Add(KEY_MIN_8);
			Controls.Add(KEY_MIN_7);
			Controls.Add(KEY_MIN_6);
			Controls.Add(KEY_MIN_5);
			Controls.Add(KEY_MIN_4);
			Controls.Add(KEY_MIN_3);
			Controls.Add(KEY_MIN_2);
			Controls.Add(KEY_MIN_1);
			Controls.Add(KEY_DIV);
			Controls.Add(KEY_multiply);
			Controls.Add(KEY_sub);
			Controls.Add(KEY_add);

			Controls.Add(KEY_Arrow_right);
			Controls.Add(KEY_Arrow_Down);
			Controls.Add(KEY_Arrow_Up);
			Controls.Add(KEY_Arrow_left);
			
			Controls.Add(KEY_QUESTION);
			Controls.Add(KEY_PERIOD);
			Controls.Add(KEY_COMMA);
			Controls.Add(KEY_TILDE);
			Controls.Add(KEY_Enter);
			Controls.Add(KEY_QUOTE);
			Controls.Add(KEY_COLON);
			Controls.Add(KEY_PIPE);
			Controls.Add(KEY_RIGHT_SQBrace);
			Controls.Add(KEY_LEFT_SQBrace);
			Controls.Add(KEY_TAB);
			Controls.Add(KEY_BACKSPACE);
			Controls.Add(KEY_ADDADD);
			Controls.Add(KEY_SubSub);
			
			Controls.Add(KEY_End);
			Controls.Add(KEY_PgDN);
			Controls.Add(KEY_PgUP);
			Controls.Add(KEY_HOME);
			Controls.Add(KEY_DEL);
			Controls.Add(KEY_INS);
			Controls.Add(KEY_PauseBreak);
			Controls.Add(KEY_PrtSc);
			Controls.Add(KEY_ESC);

			Controls.Add(KEY_F12);
			Controls.Add(KEY_F11);
			Controls.Add(KEY_F10);
			Controls.Add(KEY_F9);
			Controls.Add(KEY_F8);
			Controls.Add(KEY_F7);
			Controls.Add(KEY_F6);
			Controls.Add(KEY_F5);
			Controls.Add(KEY_F4);
			Controls.Add(KEY_F3);
			Controls.Add(KEY_F2);
			Controls.Add(KEY_F1);

			Controls.Add(KEY_0);
			Controls.Add(KEY_9);
			Controls.Add(KEY_8);
			Controls.Add(KEY_7);
			Controls.Add(KEY_6);
			Controls.Add(KEY_5);
			Controls.Add(KEY_4);
			Controls.Add(KEY_3);
			Controls.Add(KEY_2);
			Controls.Add(KEY_1);

			Controls.Add(KEY_Z);
			Controls.Add(KEY_Y);
			Controls.Add(KEY_X);
			Controls.Add(KEY_W);
			Controls.Add(KEY_V);
			Controls.Add(KEY_U);
			Controls.Add(KEY_T);
			Controls.Add(KEY_S);
			Controls.Add(KEY_R);
			Controls.Add(KEY_Q);
			Controls.Add(KEY_P);
			Controls.Add(KEY_O);
			Controls.Add(KEY_N);
			Controls.Add(KEY_M);
			Controls.Add(KEY_L);
			Controls.Add(KEY_K);
			Controls.Add(KEY_J);
			Controls.Add(KEY_I);
			Controls.Add(KEY_H);
			Controls.Add(KEY_G);
			Controls.Add(KEY_F);
			Controls.Add(KEY_E);
			Controls.Add(KEY_D);
			Controls.Add(KEY_C);
			Controls.Add(KEY_B);
			Controls.Add(KEY_A);

			Name = "Basic Keys";
			Size = new Size(760, 385);
			ResumeLayout(false);
		}
	}
}
