﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Recommendations {
	public static PanoramaImage[] interesting = new PanoramaImage[] {
		new PanoramaImage(new List<string>() {
			"http://farm9.staticflickr.com/8727/17126948797_5d8262c873_t.jpg",
			"http://farm9.staticflickr.com/8727/17126948797_5d8262c873_z.jpg",
			"http://farm9.staticflickr.com/8727/17126948797_5d8262c873_b.jpg",
			"http://farm9.staticflickr.com/8727/17126948797_5c082d62d3_k.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/81504125@N00/17126948797/", "Dirk Wandel", "Tulpenland (360 x 180)", 17126948797L)),

		new PanoramaImage(new List<string>() {
			"http://farm3.staticflickr.com/2367/2091953040_48d5ae4cee_t.jpg",
			"http://farm3.staticflickr.com/2367/2091953040_48d5ae4cee_z.jpg",
			"http://farm3.staticflickr.com/2367/2091953040_48d5ae4cee_b.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/51035756831@N01/2091953040/", "Seb Przd", "Notre Dame de Reims in HDR", 2091953040L)),

		new PanoramaImage(new List<string>() {
			"http://farm4.staticflickr.com/3719/11028304606_cc4770d8fc_t.jpg",
			"http://farm4.staticflickr.com/3719/11028304606_cc4770d8fc_z.jpg",
			"http://farm4.staticflickr.com/3719/11028304606_cc4770d8fc_b.jpg",
			"http://farm4.staticflickr.com/3719/11028304606_ce1d7d1c8d_k.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/axlemasa/11028304606/", "Masao Nagata", "2013 Tokyo Motor Show", 11028304606L)),

		new PanoramaImage(new List<string>() {
			"http://farm2.staticflickr.com/1387/767998948_9572fa0a28_t.jpg",
			"http://farm2.staticflickr.com/1387/767998948_9572fa0a28_z.jpg",
			"http://farm2.staticflickr.com/1387/767998948_9572fa0a28_b.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/83248192@N00/767998948/", "HamburgerJung", "Diner in Duckingham Palace", 767998948L)),

		new PanoramaImage(new List<string>() {
			"http://farm5.staticflickr.com/4027/4439644027_29981629fd_t.jpg",
			"http://farm5.staticflickr.com/4027/4439644027_29981629fd_z.jpg",
			"http://farm5.staticflickr.com/4027/4439644027_29981629fd_b.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/24183489@N00/4439644027/", "Alexandre Duret-Lutz", "Pont d'Iéna / Port de Suffren", 4439644027L)),

		new PanoramaImage(new List<string>() {
			"http://farm1.staticflickr.com/697/21257032388_e99fed3169_t.jpg",
			"http://farm1.staticflickr.com/697/21257032388_e99fed3169_z.jpg",
			"http://farm1.staticflickr.com/697/21257032388_e99fed3169_b.jpg",
			"http://farm1.staticflickr.com/697/21257032388_8172fcbc26_k.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/tanjabarnes/21257032388/", "Tanja Barnes", "Bellagio Conservatory & Botanical Gardens", 21257032388L)),

		new PanoramaImage(new List<string>() {
			"http://farm1.staticflickr.com/770/21142893594_cd8ed18823_t.jpg",
			"http://farm1.staticflickr.com/770/21142893594_cd8ed18823_z.jpg",
			"http://farm1.staticflickr.com/770/21142893594_cd8ed18823_b.jpg",
			"http://farm1.staticflickr.com/770/21142893594_74bfb7d919_k.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/gporada/21142893594/", "gporada", "Interaktives Völkerschlachtsdenkmal Panorama 360", 21142893594L)),

		new PanoramaImage(new List<string>() {
			"http://farm1.staticflickr.com/661/21230969582_5c642e4b0e_t.jpg",
			"http://farm1.staticflickr.com/661/21230969582_5c642e4b0e_z.jpg",
			"http://farm1.staticflickr.com/661/21230969582_5c642e4b0e_b.jpg",
			"http://farm1.staticflickr.com/661/21230969582_37cee367bd_k.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/globalvoyager/21230969582/", "Nick Hobgood", "Welcome to Leleuvia island", 21230969582L)),

		new PanoramaImage(new List<string>() {
			"http://farm1.staticflickr.com/383/19920239958_1ef5480dd0_t.jpg",
			"http://farm1.staticflickr.com/383/19920239958_1ef5480dd0_z.jpg",
			"http://farm1.staticflickr.com/383/19920239958_1ef5480dd0_b.jpg",
			"http://farm1.staticflickr.com/383/19920239958_66331fd64e_k.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/sitoo/19920239958/", "Sitoo", "Subiendo al Picu", 19920239958L)),

		new PanoramaImage(new List<string>() {
			"http://farm4.staticflickr.com/3705/10640316634_294ae3ea2d_t.jpg",
			"http://farm4.staticflickr.com/3705/10640316634_294ae3ea2d_z.jpg",
			"http://farm4.staticflickr.com/3705/10640316634_294ae3ea2d_b.jpg",
			"http://farm4.staticflickr.com/3705/10640316634_0bb22bd358_k.jpg"
		}, new ImageInfo("http://www.flickr.com/photos/81504125@N00/10640316634/", "Dirk Wandel", "Aerosol - Arena / number one (360 x 180)", 10640316634L))
	};

	public static List<long> censored = new List<long>() {
		4565661045L,
		3648173484L,
		2704842426L,
		4566289016L
	};

	public static List<PanoramaImage> stereoImages = new List<PanoramaImage>() {
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/Yofg2Lv.jpg",
			"http://i.imgur.com/Gl3qMf3.jpg",
			"http://i.imgur.com/eHTiy57.jpg",
			"http://code.blender.org/wp-content/uploads/2015/03/gooseberry_benchmark_panorama.jpg"
		}, StereoType.OVER_UNDER_INV),

		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/AnlxuJs.jpg",
			"http://i.imgur.com/etJOj9h.jpg",
			"http://i.imgur.com/DmMXc2B.jpg",
			"http://www.mediavr.com/chinesegarden1.jpg"
		}, StereoType.SBS),

		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/XJeYxCw.jpg",
			"http://i.imgur.com/W0D1iYM.jpg",
			"http://i.imgur.com/rVq1gUI.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/tPDUJiD.jpg",
			"http://i.imgur.com/K4XOLAr.jpg",
			"http://realvision.ae/blog/wp-content/uploads/2015/01/Maya_balcony_test_retinal_rivalry_reduced.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/s1Nngjr.jpg",
			"http://i.imgur.com/LIBtNCx.jpg",
			"http://i.ytimg.com/vi/LKsUxHASFBs/maxresdefault.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/B6r8MBG.jpg",
			"http://i.imgur.com/QB29MZv.jpg",
			"http://i.imgur.com/bz8njwi.jpg",
			"http://i.imgur.com/Ip4Yc7D.jpg",
			"http://i.imgur.com/bePKsgW.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/b8x0lRo.jpg",
			"http://i.imgur.com/6PYDgS1.jpg",
			"http://s10.postimg.org/ul4bea1i1/360_sbs_3_Dtest2_prev.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/tufHhCF.jpg",
			"http://i.imgur.com/80YzqAE.jpg",
			"http://i.imgur.com/n0D9Isv.jpg",
			"http://i.imgur.com/Sc2H8yU.jpg",
			"http://realvision.ae/blog/wp-content/uploads/2014/11/Dirrogate_Airport_Stereoscopic_360_VR.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/xAinxFG.jpg",
			"http://i.imgur.com/RYeDcXw.jpg",
			"http://i.imgur.com/s6LYWn3.jpg",
			"http://i.imgur.com/1WNYzka.jpg",
			"http://www.360-vr.net/misc/teidetour23_under_over_stereo_pair_4000.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/NCWsF6Q.jpg",
			"http://i.imgur.com/Xsxat81.jpg",
			"http://i.imgur.com/4emjdWg.jpg",
			"http://i.imgur.com/rhzb4JX.jpg",
			"http://www.stereopanoramas.com/townhalloverunder360s.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/Jq3Pb6Y.jpg",
			"http://i.imgur.com/s7eSBeb.jpg",
			"http://blog.dsky.co/wp-content/uploads/2015/09/06-VikingVillage_stereo_thumb.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/AaPNfud.jpg",
			"http://i.imgur.com/SMRbz40.jpg",
			"http://i.imgur.com/9nU3mfQ.jpg",
			"http://i.imgur.com/qbvlpOb.jpg",
			"http://www.stereopanoramas.com/manningoverunder360stereo.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/CtzLoYO.jpg",
			"http://i.imgur.com/SyZ8yCm.jpg",
			"http://3dx360.net/media/com_hwdmediashare/files/23/33/c5/ba9d35c5e2b554bd1b956826128eee2d.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/18Of61h.jpg",
			"http://i.imgur.com/XYb2MfA.jpg",
			"http://projects.fun4mobile.de/wp-content/uploads/sites/2/2014/07/Example1.jpg"
		}, StereoType.OVER_UNDER),
		
		new PanoramaImage(new List<string>() {
			"http://i.imgur.com/ORmn0fT.jpg",
			"http://i.imgur.com/OpMvzfp.jpg",
			"http://i.imgur.com/mI6XYys.jpg",
			"http://i.imgur.com/ybPna1c.jpg",
			"http://i.imgur.com/SeqPiFg.jpg"
		}, StereoType.OVER_UNDER)
	};
}
