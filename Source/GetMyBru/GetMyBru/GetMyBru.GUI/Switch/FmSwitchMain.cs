using GetMyBru.GetMyBru.Core;
using GetMyBru.GetMyBru.Core.Installer;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMyBru.GetMyBru.GUI
{
    public partial class FmSwitchMain : MaterialForm
    {
        private bool AppInView = false;

        public FmSwitchMain()
        {
            InitializeComponent();
            Program.EnableVisualsDefault();
        }

        private void FmSwitchMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FmSelectSystem.SafeExit == false)
            {
                this.Close();
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void FmSwitchMain_Load(object sender, EventArgs e)
        {
            LblVersion.Text = "Version: " + Application.ProductVersion;

            BruParser.ParseJSONSwitch();
            //MessageBox.Show("Packages RAW Data returned:" + Environment.NewLine + BruParser.PackagesRawList, "Packages:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TmrCheckVal_Tick(object sender, EventArgs e)
        {
            if (AppInView == true)
            {
                ShowAppInfo();
                TbSel.Enabled = false;
                return;
            }
            else if (AppInView == false)
            {
                HideAppInfo();
                TbSel.Enabled = true;
                return;
            }
        }

        private void ShowAppInfo()
        {
            //Currently this only shows on the 'Home' Tab. I'll need to fix this.

            return;
        }

        private void HideAppInfo()
        {
            return;
        }

        private void LblView_Click(object sender, EventArgs e)
        {
            if (AppInView == false)
            {
                LblView.Text = "Close Info";
                AppInView = true;
            }
            else if (AppInView == true)
            {
                LblView.Text = "View App";
                AppInView = false;
            }
        }

        private void BtnGamePixelShuffle_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "PixelShuffle";
        }

        private void BtnGameJumpBump_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "JumpBump";
        }

        private void BtnGameSnake_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Snake";
        }

        private void BtnGameTilNX_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "TilNX";
        }

        private void BtnGameMeritous_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Meritous";
        }

        private void BtnGameWhatIsInTheBox_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "WhatIsInTheBox";
        }

        private void BtnGameHCLSwitch_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "HLCSwitch";
        }

        private void BtnGameSuperMarioWar_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SuperMarioWar";
        }

        private void BtnGameLegendOfSwordFairy_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "LegondOfSwordFairy";
        }

        private void BtnGameKgDoom_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "GameKgDoom";
        }

        private void BtnGameXash_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "GameXash";
        }

        private void BtnGameTilesNX_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "TilesNX";
        }

        private void BtnGameSpaceGameNX_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SpaceGameNX";
        }

        private void BtnGameLugaru_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Lugaru";
        }

        private void BtnGame2048_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "2048";
        }

        private void BtnGameTicTacToeNX_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "TicTacToeNX";
        }

        private void BtnGameOpenLara_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "OpenLara";
        }

        private void BtnGameMystery_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Mystery";
        }

        private void BtnGameWolf4SDL_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Wolf4SDL";
        }

        private void BtnGameQuakespasm_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "QuakeSpasm";
        }

        private void BtnGameFifteen_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Fifteen";
        }

        private void BtnGamef2bgl_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "f2bgl";
        }

        private void BtnGameMinesweeper_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Minesweeper";
        }

        private void BtnGameTwoPlanes_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "TwoPlanes";
        }

        private void BtnGamePostal_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Postal";
        }

        private void BtnGameInvaders_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Invaders";
        }

        private void BtnGameBermuda_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Bermuda";
        }

        private void BtnGameNXQuake2_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "NXQuake2";
        }

        private void BtnGameHexgem_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "HexGem";
        }

        private void BtnGameGameOfLife_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "GameOfLife";
        }

        private void BtnGameTRekt_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "TRekt";
        }

        private void BtnGameCannonBall_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "CannonBall";
        }

        private void BtnGamePong_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Pong";
        }

        private void BtnGameMaze_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Maze";
        }

        private void BtnGameClawSwitch_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "ClawSwitch";
        }

        private void BtnGameSudoku_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Sudoku";
        }

        private void BtnGameTetris_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Tetris";
        }

        private void BtnGameSonicRobotBlast_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SonicRoboBlast";
        }

        private void BtnGameHata_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Hata";
        }

        private void BtnGameSimon_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Simon";
        }

        private void BtnGameDX2Switch_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "DX2Switch";
        }

        private void BtnGameHamsters_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Hamsters";
        }

        private void BtnGameDDLCLove_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "DDLC";
        }

        private void BtnGameREminiscence_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "REminiscence";
        }

        private void BtnGameEnigma_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Enigma";
        }

        private void BtnGameEduke32_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Eduke32";
        }

        private void BtnGameSdlPong_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SDLPong";
        }

        private void BtnGamePickr_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Pickr";
        }

        private void BtnGameRawgl_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Rawgl";
        }

        private void BtnGameDOOM64_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "DOOM64";
        }

        private void BtnGameNXQuake_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "NXQuake";
        }

        private void BtnGameKensLab_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "KensLab";
        }

        private void BtnGameMemoryGame_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "MemoryGame";
        }

        private void BtnGameNXEngine_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "NXEngine";
        }

        private void BtnGameMirrorMagic_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "MirrorMagic";
        }

        private void BtnGamePushA_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "PushA";
        }

        private void BtnGameChocolateDoom_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "ChocolateDoom";
        }

        private void BtnGameRocksDiamonds_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "RocksDiamonds";
        }

        private void BtnGameLiero_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Liero";
        }

        private void BtnEmuOpenBor_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "OpenBor";
        }

        private void BtnEmuBeetlePSX_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "BeetlePSX";
        }

        private void BtnEmuVBANextRetro_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "VBANextRetro";
        }

        private void BtnEmuGDKGBA_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "GDKGBA";
        }

        private void BtnEmuJaguar_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Jaguar";
        }

        private void BtnEmuMAME_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "MAME";
        }

        private void BtnEmuVBANext_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "VBANext";
        }

        private void BtnEmuScummVM_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "ScummVM";
        }

        private void BtnEmuMGBA_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "MGBA";
        }

        private void BtnEmuPSnes_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "PSnes";
        }

        private void BtnEmuPicodrive_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Picodrive";
        }

        private void BtnEmuGearboy_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Gearboy";
        }

        private void BtnEmuLaiNES_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "LaiNES";
        }

        private void BtnEmuMelonds_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Melonds";
        }

        private void BtnEmuKhedgb_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Khedgb";
        }

        private void BtnEmuRetroarch_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Retroarch";
        }

        private void BtnEmuDessmume_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Dessmume";
        }

        private void BtnEmuGenesisPlusGX_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "GenesisPlusGX";
        }

        private void BtnEmuCHIP8_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "CHIP8";
        }

        private void BtnEmuFCUMM_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "FCEUMM";
        }

        private void BtnEmuUae4all2_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Uae4all2";
        }

        private void BtnEmuSNES9x_2010_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SNES9x2010";
        }

        private void BtnEmuPFBAFInal_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "PFBAFinal";
        }

        private void BtnEmuMame2000Retro_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Mame2000Retro";
        }

        private void BtnEmuMameRetro_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "MameRetro";
        }

        private void BtnEmuNeoPopSDL_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "NeoPopSDL";
        }

        private void BtnEmuSnex9x2010_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Snes9x2010";
        }

        private void BtnEmuGambatte_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Gambatte";
        }

        private void BtnToolHBMenu_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "HBMenu";
        }

        private void BtnToolNXPlayer_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "NXPlayer";
        }

        private void BtnToolEasyPower_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "EasyPower";
        }

        private void BtnToolPixelPainter_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "PixelPainter";
        }

        private void BtnToolNXSH_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "NXSH";
        }

        private void BtnToolFTPD4SXOS_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "FTPD4SXOS";
        }

        private void BtnToolRCMReboo_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "RCMReboot";
        }

        private void BtnToolScreenTester_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "ScreenTester";
        }

        private void BtnToolYallAreNuts_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "YallAreNuts";
        }

        private void BtnToolN1DUS_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "N1DUS";
        }

        private void BtnToolPPLay_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "PPlay";
        }

        private void BtnToolBrewJS_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "BrewJS";
        }

        private void BtnToolKipSelect_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "KipSelect";
        }

        private void BtnToolAvatool_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Avatool";
        }

        private void BtnToolLockPick_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "LockPick";
        }

        private void BtnToolKEX_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Kex";
        }

        private void BtnToolSharedFont_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SharedFontDumper";
        }

        private void BtnToolVgedit_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Vgedit";
        }

        private void BtnToolGoldleaf__Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Goldleaf";
        }

        private void BtnToolGCDump_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "GCDump";
        }

        private void BtnAdvXorPlay_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "XorPlay";
        }

        private void BtnAdvHekate_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Hekate";
        }

        private void BtnAdvNXTemesInstaller_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "NXThemesInstaller";
        }

        private void BtnAdvEbooksCollection_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "EbooksCollection";
        }

        private void BtnAdvSwitchPresence_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SwitchPresence";
        }

        private void BtnAdvSysClk_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SysClk";
        }

        private void BtnAdvReiNX_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "ReiNX";
        }

        private void BtnAdvSysFTPD_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "SysFTPD";
        }

        private void BtnAdvSlide_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Slide";
        }

        private void BtnAdvNetcheat_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "AdvNetcheat";
        }

        private void BtnAdvAragon_Click(object sender, EventArgs e)
        {
            IServiceInstall.AppToInstall = "Aragon";
        }
    }
}