S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPD4
Build-Date: 2016.04.11 14:59:15

Crash Information
Process Name: goldlucks
PID: 4487
Date: 2016-08-22 16:39:36+0900
Executable File Path: /opt/usr/apps/org.example.goldlucks/bin/goldlucks
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4487, uid 5000)

Register Information
r0   = 0x8000ec77, r1   = 0xb6d9e2b0
r2   = 0x800558ae, r3   = 0x800558ae
r4   = 0xb8a47520, r5   = 0xb6dd9eac
r6   = 0x00000000, r7   = 0xbeabe1bc
r8   = 0x80056ab7, r9   = 0xb5e6e708
r10  = 0xb8a43680, fp   = 0x00000000
ip   = 0x80043e21, sp   = 0xbeabe138
lr   = 0x8000ec77, pc   = 0xb2780b04
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:    186020 KB
Buffers:     36564 KB
Cached:     313160 KB
VmPeak:     128964 KB
VmSize:     128960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27104 KB
VmRSS:       27104 KB
VmData:      45712 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35628 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4487 TID = 4487
4487 4488 4839 4840 4844 

Maps Information
afd2e000 b052d000 rw-p [stack:4844]
b1399000 b1b98000 rw-p [stack:4840]
b1c4d000 b1c55000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1c66000 b1c67000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c77000 b1c8b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c9f000 b1ca0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1cb0000 b1cb3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1cc4000 b1cc5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1cd5000 b1cd7000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1ce7000 b1ce9000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cf9000 b1d09000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1d19000 b1d25000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1d37000 b2536000 rw-p [stack:4839]
b2736000 b273d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b274e000 b2756000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2768000 b276e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b277e000 b2782000 r-xp /opt/usr/apps/org.example.goldlucks/bin/goldlucks
b28d2000 b29b5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29ec000 b2a14000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a26000 b3225000 rw-p [stack:4488]
b3225000 b3227000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3237000 b3241000 r-xp /lib/libnss_files-2.20-2014.11.so
b3252000 b325b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b326c000 b327d000 r-xp /lib/libnsl-2.20-2014.11.so
b3290000 b3296000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32a7000 b32a8000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32d0000 b32d7000 r-xp /usr/lib/libminizip.so.1.0.0
b32e7000 b32ec000 r-xp /usr/lib/libstorage.so.0.1
b32fc000 b335b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3371000 b3385000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3395000 b33d9000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33e9000 b33f1000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3401000 b3431000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3444000 b34fd000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3511000 b3564000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3575000 b3590000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35a0000 b3661000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3674000 b3684000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3694000 b36a1000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b2000 b36b9000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36c9000 b370a000 r-xp /usr/lib/libmdm.so.1.2.12
b371a000 b3722000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3731000 b3741000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3762000 b37c2000 r-xp /usr/lib/libasound.so.2.0.0
b37d4000 b37d7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37e7000 b37ea000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37fa000 b37ff000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b380f000 b3810000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3820000 b382b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b383f000 b3846000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3856000 b385c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b386c000 b3871000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3881000 b389c000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38ac000 b38b3000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c3000 b38c6000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38d7000 b3905000 r-xp /usr/lib/libidn.so.11.5.44
b3915000 b392b000 r-xp /usr/lib/libnghttp2.so.5.4.0
b393c000 b3946000 r-xp /usr/lib/libcares.so.2.1.0
b3956000 b3960000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3970000 b3972000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3982000 b3983000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3993000 b3997000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39a8000 b39d0000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e1000 b3a0a000 r-xp /usr/lib/libturbojpeg.so
b3a2a000 b3a30000 r-xp /usr/lib/libgif.so.4.1.6
b3a40000 b3a86000 r-xp /usr/lib/libcurl.so.4.3.0
b3a97000 b3ab8000 r-xp /usr/lib/libexif.so.12.3.3
b3ad3000 b3ae8000 r-xp /usr/lib/libtts.so
b3af9000 b3b01000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b11000 b3bd7000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bf7000 b3cef000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d0e000 b3ddc000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df3000 b3df5000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e05000 b3e0b000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e1b000 b3e3e000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e4f000 b3e51000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e61000 b3e63000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e74000 b3e79000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e90000 b3e92000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea2000 b3ea9000 r-xp /usr/lib/libsensord-share.so
b3eb9000 b3ed1000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee2000 b3ee5000 r-xp /usr/lib/libXv.so.1.0.0
b3ef5000 b3efa000 r-xp /usr/lib/libutilX.so.1.1.0
b3f0a000 b3f0f000 r-xp /usr/lib/libappcore-common.so.1.1
b3f1f000 b3f26000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f39000 b3f3d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f4e000 b402c000 r-xp /usr/lib/libCOREGL.so.4.0
b404c000 b404f000 r-xp /usr/lib/libuuid.so.1.3.0
b405f000 b4076000 r-xp /usr/lib/libblkid.so.1.1.0
b4087000 b4089000 r-xp /usr/lib/libXau.so.6.0.0
b4099000 b40e0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f2000 b40f8000 r-xp /usr/lib/libjson-c.so.2.0.1
b4109000 b410d000 r-xp /usr/lib/libogg.so.0.7.1
b411d000 b413f000 r-xp /usr/lib/libvorbis.so.0.4.3
b414f000 b4233000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b424f000 b4252000 r-xp /usr/lib/libEGL.so.1.4
b4263000 b4269000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4279000 b427b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b428b000 b4298000 r-xp /usr/lib/libGLESv2.so.2.0
b42a9000 b430b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4320000 b4338000 r-xp /usr/lib/libmount.so.1.1.0
b434a000 b435e000 r-xp /usr/lib/libxcb.so.1.1.0
b436e000 b4375000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ad000 b43af000 r-xp /usr/lib/libiri.so
b43bf000 b43ca000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43db000 b4411000 r-xp /usr/lib/libpulse.so.0.16.2
b4422000 b4465000 r-xp /usr/lib/libsndfile.so.1.0.25
b447a000 b448f000 r-xp /lib/libexpat.so.1.5.2
b44a1000 b455f000 r-xp /usr/lib/libcairo.so.2.11200.14
b4573000 b457b000 r-xp /usr/lib/libdrm.so.2.4.0
b458b000 b458e000 r-xp /usr/lib/libdri2.so.0.0.0
b459e000 b45ec000 r-xp /usr/lib/libssl.so.1.0.0
b4601000 b460d000 r-xp /usr/lib/libeeze.so.1.13.0
b461e000 b4627000 r-xp /usr/lib/libethumb.so.1.13.0
b4637000 b463a000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b464a000 b4801000 r-xp /usr/lib/libcrypto.so.1.0.0
b55ec000 b55f5000 r-xp /usr/lib/libXi.so.6.1.0
b5605000 b5607000 r-xp /usr/lib/libXgesture.so.7.0.0
b5617000 b561b000 r-xp /usr/lib/libXtst.so.6.1.0
b562b000 b5631000 r-xp /usr/lib/libXrender.so.1.3.0
b5641000 b5647000 r-xp /usr/lib/libXrandr.so.2.2.0
b5657000 b5659000 r-xp /usr/lib/libXinerama.so.1.0.0
b566a000 b566d000 r-xp /usr/lib/libXfixes.so.3.1.0
b567d000 b5688000 r-xp /usr/lib/libXext.so.6.4.0
b5698000 b569a000 r-xp /usr/lib/libXdamage.so.1.1.0
b56aa000 b56ac000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56bc000 b579e000 r-xp /usr/lib/libX11.so.6.3.0
b57b2000 b57b9000 r-xp /usr/lib/libXcursor.so.1.0.2
b57c9000 b57e1000 r-xp /usr/lib/libudev.so.1.6.0
b57e3000 b57e6000 r-xp /lib/libattr.so.1.1.0
b57f6000 b5816000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5817000 b581c000 r-xp /usr/lib/libffi.so.6.0.2
b582d000 b5845000 r-xp /lib/libz.so.1.2.8
b5855000 b5857000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5867000 b593c000 r-xp /usr/lib/libxml2.so.2.9.2
b5951000 b59ec000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a08000 b5a0b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a1b000 b5a34000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a45000 b5a56000 r-xp /lib/libresolv-2.20-2014.11.so
b5a6a000 b5ae4000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5af9000 b5afb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b0b000 b5b12000 r-xp /usr/lib/libembryo.so.1.13.0
b5b22000 b5b2c000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b3d000 b5b55000 r-xp /usr/lib/libpng12.so.0.50.0
b5b66000 b5b89000 r-xp /usr/lib/libjpeg.so.8.0.2
b5baa000 b5bbe000 r-xp /usr/lib/libector.so.1.13.0
b5bcf000 b5be7000 r-xp /usr/lib/liblua-5.1.so
b5bf8000 b5c4f000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c63000 b5c8b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5c9c000 b5caf000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cc0000 b5cfa000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0b000 b5d19000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d29000 b5d31000 r-xp /usr/lib/libtbm.so.1.0.0
b5d41000 b5d4e000 r-xp /usr/lib/libeio.so.1.13.0
b5d5e000 b5d60000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d70000 b5d75000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d85000 b5d9c000 r-xp /usr/lib/libefreet.so.1.13.0
b5dae000 b5dce000 r-xp /usr/lib/libeldbus.so.1.13.0
b5dde000 b5dfe000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e00000 b5e06000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e16000 b5e27000 r-xp /usr/lib/libemotion.so.1.13.0
b5e38000 b5e3f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e4f000 b5e5e000 r-xp /usr/lib/libeo.so.1.13.0
b5e6f000 b5e81000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e92000 b5e97000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ea7000 b5ec0000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed0000 b5eed000 r-xp /usr/lib/libeet.so.1.13.0
b5f06000 b5f4e000 r-xp /usr/lib/libeina.so.1.13.0
b5f5f000 b5f6f000 r-xp /usr/lib/libefl.so.1.13.0
b5f80000 b6065000 r-xp /usr/lib/libicuuc.so.51.1
b6082000 b61c2000 r-xp /usr/lib/libicui18n.so.51.1
b61d9000 b6211000 r-xp /usr/lib/libecore_x.so.1.13.0
b6223000 b6226000 r-xp /lib/libcap.so.2.21
b6236000 b625f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6270000 b6277000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6289000 b62c0000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d1000 b63bc000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63cf000 b6448000 r-xp /usr/lib/libsqlite3.so.0.8.6
b645a000 b645f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b646f000 b6479000 r-xp /usr/lib/libvconf.so.0.2.45
b6489000 b648b000 r-xp /usr/lib/libvasum.so.0.3.1
b649b000 b649d000 r-xp /usr/lib/libttrace.so.1.1
b64ad000 b64b0000 r-xp /usr/lib/libiniparser.so.0
b64c0000 b64e6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64f6000 b64fb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650c000 b6523000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6534000 b659f000 r-xp /lib/libm-2.20-2014.11.so
b65b0000 b65b6000 r-xp /lib/librt-2.20-2014.11.so
b65c7000 b65d4000 r-xp /usr/lib/libunwind.so.8.0.1
b660a000 b672e000 r-xp /lib/libc-2.20-2014.11.so
b6743000 b675c000 r-xp /lib/libgcc_s-4.9.so.1
b676c000 b684e000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b685f000 b6889000 r-xp /usr/lib/libdbus-1.so.3.8.12
b689a000 b68d6000 r-xp /usr/lib/libsystemd.so.0.4.0
b68d8000 b695b000 r-xp /usr/lib/libedje.so.1.13.0
b696e000 b698c000 r-xp /usr/lib/libecore.so.1.13.0
b69ac000 b6b33000 r-xp /usr/lib/libevas.so.1.13.0
b6b68000 b6b7c000 r-xp /lib/libpthread-2.20-2014.11.so
b6b90000 b6dc4000 r-xp /usr/lib/libelementary.so.1.13.0
b6df3000 b6df7000 r-xp /usr/lib/libsmack.so.1.0.0
b6e07000 b6e0e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e1e000 b6e20000 r-xp /usr/lib/libdlog.so.0.0.0
b6e30000 b6e33000 r-xp /usr/lib/libbundle.so.0.1.22
b6e43000 b6e45000 r-xp /lib/libdl-2.20-2014.11.so
b6e56000 b6e6e000 r-xp /usr/lib/libaul.so.0.1.0
b6e82000 b6e87000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e98000 b6ea5000 r-xp /usr/lib/liblptcp.so
b6eb7000 b6ebb000 r-xp /usr/lib/libsys-assert.so
b6ecc000 b6eec000 r-xp /lib/ld-2.20-2014.11.so
b6efd000 b6f02000 r-xp /usr/bin/launchpad-loader
b86f1000 b8a7a000 rw-p [heap]
bea9e000 beabf000 rw-p [stack]
bea9e000 beabf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4487)
Call Stack Count: 21
 0: memo_view_cb + 0x17 (0xb2780b04) [/opt/usr/apps/org.example.goldlucks/bin/goldlucks] + 0x2b04
 1: (0xb6c089a3) [/usr/lib/libelementary.so.1] + 0x789a3
 2: (0xb6a127ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5e5a219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5e58fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a13edd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb692f167) [/usr/lib/libedje.so.1] + 0x57167
 7: (0xb6933d87) [/usr/lib/libedje.so.1] + 0x5bd87
 8: (0xb692fb21) [/usr/lib/libedje.so.1] + 0x57b21
 9: (0xb692fef1) [/usr/lib/libedje.so.1] + 0x57ef1
10: (0xb6930045) [/usr/lib/libedje.so.1] + 0x58045
11: (0xb697dd11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb6979c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb697fa5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb697fc83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6e852bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb3f3b909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x110 (0xb277fe99) [/opt/usr/apps/org.example.goldlucks/bin/goldlucks] + 0x1e99
18: (0xb6efebb5) [/opt/usr/apps/org.example.goldlucks/bin/goldlucks] + 0x1bb5
19: __libc_start_main + 0x114 (0xb66204bc) [/lib/libc.so.6] + 0x164bc
20: main + 0x12b (0xb6efeeb4) [/opt/usr/apps/org.example.goldlucks/bin/goldlucks] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.goldlucks
Package ID : org.example.goldlucks
Version: 1.0.0
Package Type: tpk
App Name: goldlucks
App ID: org.example.goldlucks
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
08-22 16:39:10.147+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
08-22 16:39:10.147+0900 E/weather-agent( 4546): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
08-22 16:39:10.147+0900 I/CAPI_APPFW_APPLICATION( 4546): service_app_main.c: service_app_exit(446) > service_app_exit
08-22 16:39:10.147+0900 E/weather-agent( 4546): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
08-22 16:39:10.157+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
08-22 16:39:10.157+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
08-22 16:39:10.207+0900 W/LOCKSCREEN(  852): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
08-22 16:39:10.207+0900 E/LOCKSCREEN(  852): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
08-22 16:39:10.207+0900 E/LOCKSCREEN(  852): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
08-22 16:39:10.207+0900 W/LOCKSCREEN(  852): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
08-22 16:39:10.207+0900 W/LOCKSCREEN(  852): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
08-22 16:39:10.217+0900 E/LOCKSCREEN(  852): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
08-22 16:39:10.277+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
08-22 16:39:10.287+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 4546
08-22 16:39:10.287+0900 I/ESD     (  877): esd_main.c: __esd_app_dead_handler(1773) > pid: 4546
08-22 16:39:10.287+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:10.287+0900 I/Tizen::App( 1318): (243) > App[com.samsung.weather-m-agent] pid[4546] terminate event is forwarded
08-22 16:39:10.287+0900 I/Tizen::System( 1318): (256) > osp.accessorymanager.service provider is found.
08-22 16:39:10.287+0900 I/Tizen::System( 1318): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 4546, ]
08-22 16:39:10.287+0900 I/Tizen::System( 1318): (256) > osp.system.service provider is found.
08-22 16:39:10.287+0900 I/Tizen::App( 1318): (506) > TerminatedApp(com.samsung.weather-m-agent)
08-22 16:39:10.287+0900 I/Tizen::App( 1318): (512) > Not registered pid(4546)
08-22 16:39:10.287+0900 I/Tizen::System( 1318): (246) > Terminated app [com.samsung.weather-m-agent]
08-22 16:39:10.287+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 16:39:10.297+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 16:39:10.297+0900 I/Tizen::App( 1318): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 4546.
08-22 16:39:12.699+0900 E/EFL     (  852): ecore_x<852> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=7415397
08-22 16:39:12.699+0900 W/STARTER (  798): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
08-22 16:39:12.699+0900 W/STARTER (  798): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
08-22 16:39:12.699+0900 E/EFL     ( 4070): ecore_x<4070> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=7415397
08-22 16:39:12.859+0900 W/STARTER (  798): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
08-22 16:39:12.859+0900 E/EFL     ( 4070): ecore_x<4070> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=7415561
08-22 16:39:12.859+0900 E/EFL     (  852): ecore_x<852> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=7415561
08-22 16:39:12.859+0900 E/STARTER (  798): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
08-22 16:39:12.859+0900 E/STARTER (  798): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
08-22 16:39:12.859+0900 E/STARTER (  798): )
08-22 16:39:12.859+0900 I/SYSPOPUP(  858): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
08-22 16:39:12.859+0900 I/SYSPOPUP(  858): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
08-22 16:39:12.859+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
08-22 16:39:12.859+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
08-22 16:39:13.060+0900 W/STARTER (  798): hw_key.c: _homekey_timer_cb(479) > [_homekey_timer_cb:479] _homekey_timer_cb, homekey count[1], lock state[0]
08-22 16:39:13.070+0900 E/STARTER (  798): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
08-22 16:39:13.070+0900 E/STARTER (  798): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
08-22 16:39:13.070+0900 E/STARTER (  798): )
08-22 16:39:13.070+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
08-22 16:39:13.070+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 860
08-22 16:39:13.080+0900 W/AUL     (  798): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
08-22 16:39:13.080+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
08-22 16:39:13.090+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
08-22 16:39:13.090+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
08-22 16:39:13.090+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 798
08-22 16:39:13.090+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
08-22 16:39:13.100+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 860, appid: com.samsung.homescreen
08-22 16:39:13.100+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 0, pid: 860
08-22 16:39:13.100+0900 W/AUL_AMD (  610): amd_request.c: __send_home_launch_signal(577) > send a home launch signal
08-22 16:39:13.110+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESET State: PAUSED
08-22 16:39:13.110+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
08-22 16:39:13.110+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
08-22 16:39:13.110+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
08-22 16:39:13.110+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
08-22 16:39:13.110+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(860), cmd(0)
08-22 16:39:13.110+0900 W/AUL     (  798): launch.c: app_request_to_launchpad(425) > request cmd(0) result(860)
08-22 16:39:13.110+0900 E/STARTER (  798): dbus-util.c: starter_dbus_home_raise_signal_send(219) > [starter_dbus_home_raise_signal_send:219] Sending HOME RAISE signal, result:0
08-22 16:39:13.120+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
08-22 16:39:13.120+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
08-22 16:39:13.140+0900 W/CAPI_APPFW_APP_CONTROL(  860): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
08-22 16:39:13.150+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
08-22 16:39:13.150+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(566) > [APP 860] App already running, raise the window
08-22 16:39:13.160+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
08-22 16:39:13.160+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-22 16:39:13.160+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
08-22 16:39:13.160+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
08-22 16:39:13.160+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
08-22 16:39:13.180+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
08-22 16:39:13.200+0900 E/weather-widget( 1393): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
08-22 16:39:13.220+0900 E/weather-common( 1393): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
08-22 16:39:13.220+0900 E/PKGMGR_SERVER( 4583): pkgmgr-server.c: main(2414) > package manager server start
08-22 16:39:13.230+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 16:39:13.230+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 16:39:13.240+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
08-22 16:39:13.240+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-22 16:39:13.250+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
08-22 16:39:13.250+0900 I/APP_CORE( 4070): appcore-efl.c: __do_app(514) > [APP 4070] Event: PAUSE State: RUNNING
08-22 16:39:13.250+0900 I/CAPI_APPFW_APPLICATION( 4070): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
08-22 16:39:13.260+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(4070) status(4)
08-22 16:39:13.260+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.scheduler(4070)
08-22 16:39:13.260+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 4070, appid: org.example.scheduler, status: bg
08-22 16:39:13.270+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:13.270+0900 I/TIZEN_N_SOUND_MANAGER(  896): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
08-22 16:39:13.270+0900 E/TIZEN_N_SOUND_MANAGER(  896): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-22 16:39:13.280+0900 I/TIZEN_N_SOUND_MANAGER(  896): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
08-22 16:39:13.280+0900 E/TIZEN_N_SOUND_MANAGER(  896): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-22 16:39:13.280+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
08-22 16:39:13.290+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_create(409) > New handle created[0xb806edf8]
08-22 16:39:13.290+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_get_type(463) > Connected Network = 0
08-22 16:39:13.290+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
08-22 16:39:13.290+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
08-22 16:39:13.290+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_destroy(427) > Destroy handle: 0xb806edf8
08-22 16:39:13.290+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
08-22 16:39:13.290+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
08-22 16:39:13.290+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
08-22 16:39:13.290+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
08-22 16:39:13.290+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
08-22 16:39:13.290+0900 W/AUL     ( 1393): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1393, appid: com.samsung.weather-m-widget, status: fg
08-22 16:39:13.300+0900 I/Tizen::System( 1318): (259) > Active app [com.samsun], current [org.exampl] 
08-22 16:39:13.300+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 16:39:13.300+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 4070): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 50
08-22 16:39:13.300+0900 E/APP_CORE( 4070): appcore-efl.c: _capture_and_make_file(1619) > win[6800002] widget[720] height[1280]
08-22 16:39:13.310+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
08-22 16:39:13.400+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 16:39:13.410+0900 E/PKGMGR_SERVER( 4583): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.goldlucks] is null
08-22 16:39:13.420+0900 E/PKGMGR  ( 4581): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.goldlucks, -1]
08-22 16:39:13.470+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
08-22 16:39:13.470+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 4178
08-22 16:39:13.480+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
08-22 16:39:13.490+0900 E/PKGMGR_SERVER( 4583): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.goldlucks] fail
08-22 16:39:13.490+0900 E/PKGMGR_SERVER( 4583): pkgmgr-server.c: sighandler(417) > child NORMAL exit [4617]
08-22 16:39:14.731+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7417444
08-22 16:39:14.771+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
08-22 16:39:14.771+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
08-22 16:39:14.791+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __provider_pause_cb(304) > widget obj was paused
08-22 16:39:14.791+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __check_status_for_cgroup(152) > enter background group
08-22 16:39:14.791+0900 W/AUL     ( 1393): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1393, appid: com.samsung.weather-m-widget, status: bg
08-22 16:39:14.861+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7417574
08-22 16:39:15.112+0900 I/APP_CORE(  852): appcore-efl.c: __do_app(514) > [APP 852] Event: MEM_FLUSH State: PAUSED
08-22 16:39:15.152+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-22 16:39:15.292+0900 E/PKGMGR_SERVER( 4583): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-22 16:39:15.292+0900 E/PKGMGR_SERVER( 4583): pkgmgr-server.c: main(2471) > package manager server terminated.
08-22 16:39:15.502+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7418217
08-22 16:39:15.592+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7418304
08-22 16:39:15.872+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
08-22 16:39:16.263+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:16.263+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 16:39:16.263+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:16.263+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 16:39:18.255+0900 I/APP_CORE( 4070): appcore-efl.c: __do_app(514) > [APP 4070] Event: MEM_FLUSH State: PAUSED
08-22 16:39:20.036+0900 E/PKGMGR  ( 4717): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
08-22 16:39:20.117+0900 E/PKGMGR_SERVER( 4719): pkgmgr-server.c: main(2414) > package manager server start
08-22 16:39:20.167+0900 E/PKGMGR_SERVER( 4719): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.goldlucks]
08-22 16:39:20.177+0900 E/PKGMGR_SERVER( 4719): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.goldlucks errno: 2 (No such file or directory)[0;m
08-22 16:39:20.177+0900 E/PKGMGR_SERVER( 4719): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.goldlucks] is null
08-22 16:39:20.177+0900 E/PKGMGR  ( 4717): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[47170002]
08-22 16:39:20.327+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: start, val: update
08-22 16:39:20.327+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [start], Value = [update], install = [1]
08-22 16:39:20.337+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
08-22 16:39:20.337+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: install_percent, val: 30
08-22 16:39:20.337+0900 I/Tizen::App( 1318): (119) > InstallationInProgress [30]
08-22 16:39:20.337+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [install_percent], Value = [30], install = [1]
08-22 16:39:20.437+0900 W/CERT_SVC_VCORE( 4722): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
08-22 16:39:20.477+0900 E/rpm-installer( 4722): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
08-22 16:39:20.477+0900 E/rpm-installer( 4722): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
08-22 16:39:20.537+0900 E/PKGMGR_PARSER( 4722): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
08-22 16:39:20.577+0900 E/PKGMGR_CERT( 4722): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
08-22 16:39:20.577+0900 E/PKGMGR_CERT( 4722): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
08-22 16:39:20.587+0900 E/PKGMGR_CERT( 4722): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
08-22 16:39:20.627+0900 E/rpm-installer( 4722): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.goldlucks) failed.
08-22 16:39:20.627+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: end, val: fail
08-22 16:39:20.627+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [end], Value = [fail], install = [96]
08-22 16:39:20.627+0900 E/ESD     (  877): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
08-22 16:39:20.637+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
08-22 16:39:20.637+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.goldlucks",~) returned -1
08-22 16:39:20.637+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
08-22 16:39:22.299+0900 E/PKGMGR_SERVER( 4719): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
08-22 16:39:22.469+0900 E/PKGMGR_SERVER( 4719): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.goldlucks] fail
08-22 16:39:22.469+0900 E/PKGMGR_SERVER( 4719): pkgmgr-server.c: sighandler(417) > child NORMAL exit [4722]
08-22 16:39:24.291+0900 E/PKGMGR_SERVER( 4719): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-22 16:39:24.291+0900 E/PKGMGR_SERVER( 4719): pkgmgr-server.c: main(2471) > package manager server terminated.
08-22 16:39:24.741+0900 E/PKGMGR  ( 4772): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
08-22 16:39:24.821+0900 E/PKGMGR_SERVER( 4774): pkgmgr-server.c: main(2414) > package manager server start
08-22 16:39:24.861+0900 E/PKGMGR_SERVER( 4774): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.goldlucks-1.0.0-arm.tpk]
08-22 16:39:24.871+0900 E/PKGMGR_INFO( 4774): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.goldlucks-1.0.0-arm.tpk] not found in DB
08-22 16:39:24.881+0900 E/rpm-installer( 4774): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
08-22 16:39:24.881+0900 E/PKGMGR_SERVER( 4774): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
08-22 16:39:24.881+0900 E/PKGMGR_SERVER( 4774): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.goldlucks-1.0.0-arm.tpk] is null
08-22 16:39:24.891+0900 E/PKGMGR  ( 4772): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[47720002]
08-22 16:39:25.001+0900 E/PKGMGR_INSTALLER( 4777): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
08-22 16:39:25.001+0900 E/rpm-installer( 4777): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.goldlucks-1.0.0-arm.tpk] is tpk package.
08-22 16:39:25.021+0900 E/rpm-installer( 4777): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
08-22 16:39:25.021+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
08-22 16:39:25.021+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_get_value_list(1104) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
08-22 16:39:25.021+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
08-22 16:39:25.021+0900 E/rpm-installer( 4777): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
08-22 16:39:25.021+0900 E/rpm-installer( 4777): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
08-22 16:39:25.081+0900 W/CERT_SVC_VCORE( 4777): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
08-22 16:39:25.131+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: start, val: install
08-22 16:39:25.131+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [start], Value = [install], install = [96]
08-22 16:39:25.141+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: install_percent, val: 30
08-22 16:39:25.141+0900 I/Tizen::App( 1318): (119) > InstallationInProgress [30]
08-22 16:39:25.141+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [install_percent], Value = [30], install = [96]
08-22 16:39:25.232+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
08-22 16:39:25.232+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
08-22 16:39:25.232+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
08-22 16:39:25.232+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
08-22 16:39:25.242+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
08-22 16:39:25.242+0900 E/rpm-installer( 4777): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
08-22 16:39:25.242+0900 E/PKGMGR_PARSER( 4777): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
08-22 16:39:25.252+0900 E/PKGMGR_PARSER( 4777): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
08-22 16:39:25.482+0900 E/PKGMGR_PARSER( 4777): pkgmgr_parser.c: __check_theme(142) > theme for installation.
08-22 16:39:25.572+0900 E/PKGMGR_CERT( 4777): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
08-22 16:39:25.572+0900 E/PKGMGR_CERT( 4777): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 116
08-22 16:39:25.572+0900 E/PKGMGR_CERT( 4777): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 116
08-22 16:39:25.582+0900 E/PKGMGR_CERT( 4777): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 8
08-22 16:39:25.582+0900 E/PKGMGR_CERT( 4777): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 33 10
08-22 16:39:25.582+0900 E/PKGMGR_CERT( 4777): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 34 10
08-22 16:39:25.582+0900 E/PKGMGR_CERT( 4777): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 37 5
08-22 16:39:25.592+0900 E/PKGMGR_CERT( 4777): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
08-22 16:39:25.592+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: install_percent, val: 60
08-22 16:39:25.592+0900 I/Tizen::App( 1318): (119) > InstallationInProgress [60]
08-22 16:39:25.592+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [install_percent], Value = [60], install = [96]
08-22 16:39:25.612+0900 E/rpm-installer( 4777): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
08-22 16:39:25.632+0900 E/rpm-installer( 4777): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
08-22 16:39:25.632+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: install_percent, val: 100
08-22 16:39:25.632+0900 I/Tizen::App( 1318): (119) > InstallationInProgress [100]
08-22 16:39:25.632+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [install_percent], Value = [100], install = [96]
08-22 16:39:27.294+0900 E/PKGMGR_SERVER( 4774): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
08-22 16:39:27.714+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
08-22 16:39:27.714+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
08-22 16:39:27.714+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
08-22 16:39:27.724+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: end, val: ok
08-22 16:39:27.724+0900 I/Tizen::App( 1318): (78) > Installation is Completed. [Package = org.example.goldlucks]
08-22 16:39:27.724+0900 I/Tizen::App( 1318): (671) > Enter. package(org.example.goldlucks), installationResult(0)
08-22 16:39:27.734+0900 E/PKGMGR_INFO( 1318): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(1119) > (_pkgmgrinfo_pkginfo_get_theme_icon(handle, icon) == PMINFO_R_OK) theme_ico(org.example.goldlucks) is found
08-22 16:39:27.734+0900 I/Tizen::App( 1318): (1360) > package(org.example.goldlucks), version(1.0.0), type(tpk), displayName(goldlucks), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.goldlucks), storeClient(), appRootPath(/opt/usr/apps/org.example.goldlucks)
08-22 16:39:27.734+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
08-22 16:39:27.744+0900 I/Tizen::App( 1318): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.goldlucks]
08-22 16:39:27.744+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.goldlucks]
08-22 16:39:27.744+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.goldlucks]
08-22 16:39:27.744+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
08-22 16:39:27.744+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
08-22 16:39:27.744+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.goldlucks]
08-22 16:39:27.754+0900 I/Tizen::App( 1318): (416) > appName = [goldlucks]
08-22 16:39:27.754+0900 E/PKGMGR_INFO( 1318): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1914) > (_pkgmgrinfo_appinfo_get_theme_icon(handle, icon) == PMINFO_R_OK) theme_ico(org.example.goldlucks) is found
08-22 16:39:27.754+0900 I/Tizen::App( 1318): (509) > exe = [/opt/usr/apps/org.example.goldlucks/bin/goldlucks], displayName = [goldlucks], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-22 16:39:27.754+0900 E/PKGMGR_INFO( 1318): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
08-22 16:39:27.754+0900 I/Tizen::App( 1318): (683) > Application count(1) in this package
08-22 16:39:27.754+0900 I/Tizen::App( 1318): (840) > Enter.
08-22 16:39:27.754+0900 I/Tizen::App( 1318): (703) > Exit.
08-22 16:39:27.754+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [end], Value = [ok], install = [96]
08-22 16:39:27.754+0900 E/PKGMGR_INFO(  860): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1914) > (_pkgmgrinfo_appinfo_get_theme_icon(handle, icon) == PMINFO_R_OK) theme_ico(org.example.goldlucks) is found
08-22 16:39:27.754+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[goldlucks] enable[1] system[0]
08-22 16:39:27.754+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.goldlucks] mdm is not enabled
08-22 16:39:27.754+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[goldlucks] enable[1] system[0]
08-22 16:39:27.764+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/data/theme/icon/app/org.example.goldlucks.png], New icon path[/opt/usr/data/theme/icon/app/org.example.goldlucks.png]!!!!!
08-22 16:39:27.764+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
08-22 16:39:27.774+0900 I/Tizen::App( 1318): (416) > appName = [goldlucks]
08-22 16:39:27.774+0900 E/PKGMGR_INFO( 1318): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1914) > (_pkgmgrinfo_appinfo_get_theme_icon(handle, icon) == PMINFO_R_OK) theme_ico(org.example.goldlucks) is found
08-22 16:39:27.774+0900 I/Tizen::App( 1318): (509) > exe = [/opt/usr/apps/org.example.goldlucks/bin/goldlucks], displayName = [goldlucks], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-22 16:39:27.774+0900 I/Tizen::App( 1318): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.goldlucks.info]
08-22 16:39:27.774+0900 I/Tizen::App( 1318): (131) > Enter
08-22 16:39:27.774+0900 I/Tizen::App( 1318): (137) > org.example.goldlucks does not have launch condition
08-22 16:39:27.774+0900 I/Tizen::App( 1318): (883) > Exit.
08-22 16:39:27.784+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/data/theme/icon/app/org.example.goldlucks.png], Loading state:[1]
08-22 16:39:27.804+0900 E/PKGMGR_SERVER( 4774): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.goldlucks-1.0.0-arm.tpk] fail
08-22 16:39:27.804+0900 E/PKGMGR_SERVER( 4774): pkgmgr-server.c: sighandler(417) > child NORMAL exit [4777]
08-22 16:39:29.295+0900 E/PKGMGR_SERVER( 4774): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-22 16:39:29.295+0900 E/PKGMGR_SERVER( 4774): pkgmgr-server.c: main(2471) > package manager server terminated.
08-22 16:39:33.540+0900 W/AUL     ( 4832): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.goldlucks)
08-22 16:39:33.540+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
08-22 16:39:33.550+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
08-22 16:39:33.550+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
08-22 16:39:33.550+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
08-22 16:39:33.550+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 4832
08-22 16:39:33.550+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
08-22 16:39:33.560+0900 E/RESOURCED(  666): block.c: block_prelaunch_state(134) > insert data org.example.goldlucks, table num : 6
08-22 16:39:33.560+0900 E/RESOURCED(  666): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
08-22 16:39:33.570+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
08-22 16:39:33.570+0900 W/AUL_PAD ( 1502): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
08-22 16:39:33.570+0900 W/AUL_PAD ( 1502): launchpad.c: __send_result_to_caller(267) > Check app launching
08-22 16:39:33.580+0900 I/CAPI_APPFW_APPLICATION( 4487): app_main.c: ui_app_main(789) > app_efl_main
08-22 16:39:33.590+0900 I/CAPI_APPFW_APPLICATION( 4487): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
08-22 16:39:33.610+0900 E/TBM     ( 4487): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
08-22 16:39:33.670+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 4487, appid: org.example.goldlucks
08-22 16:39:33.670+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
08-22 16:39:33.680+0900 W/AUL     ( 4832): launch.c: app_request_to_launchpad(425) > request cmd(0) result(4487)
08-22 16:39:33.690+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:33.690+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 16:39:33.690+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:33.690+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 16:39:33.840+0900 I/APP_CORE( 4487): appcore-efl.c: __do_app(514) > [APP 4487] Event: RESET State: CREATED
08-22 16:39:33.840+0900 I/CAPI_APPFW_APPLICATION( 4487): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
08-22 16:39:33.840+0900 E/EFL     ( 4487): edje<4487> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-22 16:39:33.840+0900 E/EFL     ( 4487): By the power of Grayskull, your previous Embryo stack is now broken!
08-22 16:39:33.850+0900 E/EFL     ( 4487): edje<4487> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-22 16:39:33.850+0900 E/EFL     ( 4487): By the power of Grayskull, your previous Embryo stack is now broken!
08-22 16:39:33.850+0900 E/EFL     ( 4487): edje<4487> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-22 16:39:33.850+0900 E/EFL     ( 4487): By the power of Grayskull, your previous Embryo stack is now broken!
08-22 16:39:33.870+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 16:39:33.870+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 16:39:33.900+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
08-22 16:39:33.900+0900 I/Tizen::System( 1318): (259) > Active app [org.exampl], current [com.samsun] 
08-22 16:39:33.900+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 16:39:33.900+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 16:39:33.910+0900 W/APP_CORE( 4487): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6600002
08-22 16:39:33.910+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
08-22 16:39:33.910+0900 E/EFL     ( 4487): elementary<4487> elm_scroller.c:1094 elm_scroller_page_size_set() The object ((nil)) doesn't implement the Elementary scrollable interface
08-22 16:39:33.990+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
08-22 16:39:33.990+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
08-22 16:39:33.990+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
08-22 16:39:33.990+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
08-22 16:39:33.990+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
08-22 16:39:33.990+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
08-22 16:39:34.000+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(4487) status(3)
08-22 16:39:34.000+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-22 16:39:34.000+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
08-22 16:39:34.000+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.goldlucks(4487)
08-22 16:39:34.000+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 4487, appid: org.example.goldlucks, status: fg
08-22 16:39:34.040+0900 I/APP_CORE( 4487): appcore-efl.c: __do_app(514) > [APP 4487] Event: RESUME State: CREATED
08-22 16:39:34.050+0900 I/APP_CORE( 4487): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
08-22 16:39:34.050+0900 I/APP_CORE( 4487): appcore-efl.c: __do_app(625) > [APP 4487] Initial Launching, call the resume_cb
08-22 16:39:34.050+0900 I/CAPI_APPFW_APPLICATION( 4487): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-22 16:39:34.160+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:34.160+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 16:39:34.160+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:34.160+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 16:39:34.350+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(4487) status(0)
08-22 16:39:34.701+0900 E/RESOURCED(  666): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.460
08-22 16:39:34.711+0900 I/Tizen::App( 1318): (499) > LaunchedApp(org.example.goldlucks)
08-22 16:39:34.711+0900 I/Tizen::App( 1318): (733) > Finished invoking application event listener for org.example.goldlucks, 4487.
08-22 16:39:35.191+0900 E/RESOURCED(  666): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.461
08-22 16:39:35.462+0900 I/UXT     ( 4841): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
08-22 16:39:35.562+0900 E/EFL     ( 4487): ecore_x<4487> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7438275
08-22 16:39:35.662+0900 E/EFL     ( 4487): ecore_x<4487> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7438362
08-22 16:39:35.672+0900 E/VCONF   ( 4487): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
08-22 16:39:35.672+0900 E/VCONF   ( 4487): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
08-22 16:39:35.672+0900 E/VCONF   ( 4487): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
08-22 16:39:35.672+0900 E/VCONF   ( 4487): vconf.c: vconf_get_bool(2729) > vconf_get_bool(4487) : db/ise/keysound error
08-22 16:39:35.672+0900 E/VCONF   ( 4487): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
08-22 16:39:35.672+0900 E/VCONF   ( 4487): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
08-22 16:39:35.712+0900 E/EFL     ( 4487): eo<4487> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb6ef9ae8 is not pointing to a valid object. Maybe it has already been freed.
08-22 16:39:35.712+0900 E/EFL     ( 4487): eo<4487> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb6ef9ae8) is an invalid ref.
08-22 16:39:36.623+0900 E/EFL     ( 4487): ecore_x<4487> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7439333
08-22 16:39:36.713+0900 E/EFL     ( 4487): ecore_x<4487> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7439419
08-22 16:39:36.873+0900 I/AUL_PAD ( 1502): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 4487 pgid = 4487
08-22 16:39:36.873+0900 I/AUL_PAD ( 1502): sigchild.h: __sigchild_action(143) > dead_pid(4487)
08-22 16:39:36.883+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 16:39:36.893+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
08-22 16:39:36.893+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-22 16:39:36.893+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
08-22 16:39:36.893+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
08-22 16:39:36.893+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
08-22 16:39:36.933+0900 I/AUL_PAD ( 1502): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-22 16:39:36.933+0900 I/AUL_PAD ( 1502): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-22 16:39:36.933+0900 E/AUL_PAD ( 1502): launchpad.c: main(698) > error reading sigchld info
08-22 16:39:36.943+0900 I/ESD     (  877): esd_main.c: __esd_app_dead_handler(1773) > pid: 4487
08-22 16:39:36.943+0900 I/Tizen::App( 1318): (243) > App[org.example.goldlucks] pid[4487] terminate event is forwarded
08-22 16:39:36.943+0900 I/Tizen::System( 1318): (256) > osp.accessorymanager.service provider is found.
08-22 16:39:36.943+0900 I/Tizen::System( 1318): (196) > Accessory Owner is removed [org.example.goldlucks, 4487, ]
08-22 16:39:36.943+0900 I/Tizen::System( 1318): (256) > osp.system.service provider is found.
08-22 16:39:36.943+0900 I/Tizen::App( 1318): (506) > TerminatedApp(org.example.goldlucks)
08-22 16:39:36.943+0900 I/Tizen::App( 1318): (512) > Not registered pid(4487)
08-22 16:39:36.943+0900 I/Tizen::System( 1318): (246) > Terminated app [org.example.goldlucks]
08-22 16:39:36.943+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 16:39:36.943+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 4487
08-22 16:39:36.943+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 4487
08-22 16:39:36.943+0900 E/RESOURCED(  666): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.464
08-22 16:39:36.953+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
08-22 16:39:36.953+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 16:39:36.963+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 16:39:36.963+0900 I/Tizen::App( 1318): (782) > Finished invoking application event listener for org.example.goldlucks, 4487.
08-22 16:39:36.963+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 16:39:36.963+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
08-22 16:39:36.963+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-22 16:39:36.963+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
08-22 16:39:36.993+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
08-22 16:39:37.003+0900 I/Tizen::System( 1318): (259) > Active app [com.samsun], current [org.exampl] 
08-22 16:39:37.003+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 16:39:37.013+0900 E/weather-widget( 1393): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
08-22 16:39:37.013+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 16:39:37.033+0900 I/TIZEN_N_SOUND_MANAGER(  896): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
08-22 16:39:37.033+0900 E/TIZEN_N_SOUND_MANAGER(  896): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-22 16:39:37.033+0900 W/CRASH_MANAGER( 4847): worker.c: worker_job(1199) > 1104487676f6c147185157
