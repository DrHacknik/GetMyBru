using GetMyBru.GetMyBru.Core;
using GetMyBru.GetMyBru.Core.Installer;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public static string AppToInstall;

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
            PrgInstall.Value = int.Parse(Math.Truncate(IServiceInstall.percentage).ToString());
            if (IServiceInstall.Downloading == true)
            {
                this.Enabled = false;
                LblInstalling.Visible = true;
                LblInstalling.Text = "Downloading package: " + AppToInstall;
            }
            else if (IServiceInstall.Installing == false)
            {
                this.Enabled = true;

                LblInstalling.Visible = false;
            }

            if (IServiceInstall.Downloading == false && IServiceInstall.Installing == true)
            {
                this.Enabled = false;
                LblInstalling.Text = "Installing package: " + AppToInstall;
            }

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

            //if (IServiceInstall.PackageProgress > 0)
            //{
            //    PrgInstall.Value = IServiceInstall.PackageProgress;
            //}
            //else if (IServiceInstall.PackageDownloadComplete == true)
            //{
            //    PrgInstall.Value = 100;
            //    MessageBox.Show("Packaged installed.");
            //    return;
            //}
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
            AppToInstall = IHomebrewList.GamePixelShuffle;
            IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameJumpBump_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamePixelShuffle;
            IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameSnake_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamePixelShuffle;
            IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameTilNX_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamePixelShuffle;
            IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameMeritous_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamePixelShuffle;
            IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameWhatIsInTheBox_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamePixelShuffle;
            IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameHCLSwitch_Click(object sender, EventArgs e)
        {
            return;
        }

        private void BtnGameSuperMarioWar_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameSuperMarioWar; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameLegendOfSwordFairy_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameLegendOfSwordAndFairy; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameKgDoom_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameKGDOOM; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameXash_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameXash3d; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameTilesNX_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameTiles; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameSpaceGameNX_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameSpaceGame; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameLugaru_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameLugaru; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGame2048_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.Game2048; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameTicTacToeNX_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameTicTacToe; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameOpenLara_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameOpenLara; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameMystery_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameSolarusDX; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameWolf4SDL_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameWolf4SDL; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameQuakespasm_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameQuakeSpasmNX; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameFifteen_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameFifteen; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGamef2bgl_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameF2BGL; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameMinesweeper_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameMinesweeper; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameTwoPlanes_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameTwoPlanes; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGamePostal_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamePostal; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameInvaders_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameInvaders; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameBermuda_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameBermuda; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameNXQuake2_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameNXQuake; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameHexgem_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameHexGem; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameGameOfLife_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameGameOfLife; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameTRekt_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameTREKT; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameCannonBall_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameCannonBall; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGamePong_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamesPong; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameMaze_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameMazeNX; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameClawSwitch_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameClawSwitch; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameSudoku_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameSudokunx; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameTetris_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameTetrisSwitch; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameSonicRobotBlast_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameSonicRoboBlastTwo; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameHata_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameHATA; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameSimon_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameSimonNX; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameDX2Switch_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameDX2Switch; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameHamsters_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameHamsterNX; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameDDLCLove_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameDDLCLove; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameREminiscence_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameREMiniscence; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameEnigma_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameEnigma; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameEduke32_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameEduke32; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameSdlPong_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameSDLPong; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGamePickr_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamePickr; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameRawgl_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameRawgl; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameDOOM64_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameDOOM64EX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameNXQuake_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameNXQuake; ; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameKensLab_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameKensLab; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameMemoryGame_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameMemoryGameNX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameNXEngine_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameNXEngineEvo; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameMirrorMagic_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameMirrorMagic; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGamePushA_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GamePushANX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameChocolateDoom_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameChocolateDOOM; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameRocksDiamonds_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameRocksDiamonds; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnGameLiero_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.GameLIERO; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuOpenBor_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuOpenBor; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuBeetlePSX_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuBeetlePSX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuVBANextRetro_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuVBANEXTRetro; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuGDKGBA_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuGDKGBA; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuJaguar_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuVirtualJag; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuMAME_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuMAMENX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuVBANext_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuVBANEXT; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuScummVM_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuScummVM; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuMGBA_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuMGBA; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuPSnes_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuPSNES; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuPicodrive_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuPicoDrive; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuGearboy_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuGearboy; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuLaiNES_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuLaines; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuMelonds_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuMelondDS; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuKhedgb_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuKHEDGB; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuRetroarch_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuRetroarch; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuDessmume_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuDesmume; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuGenesisPlusGX_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuGenesisPlusNX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuCHIP8_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuCHIP8NX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuFCUMM_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuFCEUMM; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuUae4all2_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuUAE4ALL2; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuSNES9x_2010_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuSNES9x2010; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuPFBAFInal_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuPFBA; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuMame2000Retro_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuMAME2000Retro; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuMameRetro_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuMAMERetro; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuNeoPopSDL_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuNEOPOPSDL; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuSnex9x2010_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuSNES9x2010NX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnEmuGambatte_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.EmuGameBatte; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolHBMenu_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolHBMenu; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolNXPlayer_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolNXPlay; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolEasyPower_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolEasyPower; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolPixelPainter_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolPixelPainter; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolNXSH_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolNXSH; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolFTPD4SXOS_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolFTPDSXOS; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolRCMReboo_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolRCMReboot; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolScreenTester_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolScreenTesterNX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolYallAreNuts_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolYALLARENUTS; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolN1DUS_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolN1DUS; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolPPLay_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolPPlay; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolBrewJS_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolBrewJS; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolKipSelect_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolKIPSELECT; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolAvatool_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolAvatool; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolLockPick_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolLockPick; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolKEX_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolKEX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolSharedFont_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolSharedFont; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolVgedit_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolVgedit; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolGoldleaf__Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolGoldleaf; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnToolGCDump_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.ToolGCDumpTool; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvXorPlay_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvXORPLAY; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvHekate_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvHekate; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvNXTemesInstaller_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvNXTHEMESINSTALLER; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvEbooksCollection_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvEbooksCollection; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvSwitchPresence_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvSwitchPresence; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvSysClk_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvSysClk; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvReiNX_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvReiNX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvSysFTPD_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvSysFTPD; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvSlide_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvSLIDENX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvNetcheat_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvSysNETCHEAT; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnAdvAragon_Click(object sender, EventArgs e)
        {
            AppToInstall = IHomebrewList.AdvArgonNX; IServiceInstall.InstallSwitch(AppToInstall);
        }

        private void BtnViewDownloads_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + "\\Data\\Cache\\Switch");
            return;
        }
    }
}