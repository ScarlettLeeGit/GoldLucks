S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPD4
Build-Date: 2016.04.11 14:59:15

Crash Information
Process Name: goldlucks
PID: 1504
Date: 2016-08-22 14:05:58+0900
Executable File Path: /opt/usr/apps/org.example.goldlucks/bin/goldlucks
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1504, uid 5000)

Register Information
r0   = 0x8000ec77, r1   = 0xb6e172b0
r2   = 0x801558b2, r3   = 0x801558b2
r4   = 0xb894a318, r5   = 0xb6e52eac
r6   = 0x00000000, r7   = 0xbeb361bc
r8   = 0x80156abb, r9   = 0xb5ee7708
r10  = 0xb89b7c88, fp   = 0x00000000
ip   = 0x80143e25, sp   = 0xbeb36138
lr   = 0x8000ec77, pc   = 0xb27f9b04
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:    245452 KB
Buffers:     31920 KB
Cached:     305960 KB
VmPeak:     131848 KB
VmSize:     130556 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28820 KB
VmRSS:       27924 KB
VmData:      47308 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35628 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 1504 TID = 1504
1504 1517 1781 1782 1787 

Maps Information
afa4a000 b05b1000 rw-p [stack:1787]
b1412000 b1c11000 rw-p [stack:1782]
b1cc6000 b1cce000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1cdf000 b1ce0000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1cf0000 b1d04000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1d18000 b1d19000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1d29000 b1d2c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1d3d000 b1d3e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1d4e000 b1d50000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1d60000 b1d62000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1d72000 b1d82000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1d92000 b1d9e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1db0000 b25af000 rw-p [stack:1781]
b27af000 b27b6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c7000 b27cf000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27e1000 b27e7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f7000 b27fb000 r-xp /opt/usr/apps/org.example.goldlucks/bin/goldlucks
b294b000 b2a2e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a65000 b2a8d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a9f000 b329e000 rw-p [stack:1517]
b329e000 b32a0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32b0000 b32ba000 r-xp /lib/libnss_files-2.20-2014.11.so
b32cb000 b32d4000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32e5000 b32f6000 r-xp /lib/libnsl-2.20-2014.11.so
b3309000 b330f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3320000 b3321000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3349000 b3350000 r-xp /usr/lib/libminizip.so.1.0.0
b3360000 b3365000 r-xp /usr/lib/libstorage.so.0.1
b3375000 b33d4000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33ea000 b33fe000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b340e000 b3452000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3462000 b346a000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b347a000 b34aa000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34bd000 b3576000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b358a000 b35dd000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35ee000 b3609000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3619000 b36da000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36ed000 b36fd000 r-xp /usr/lib/libefl-assist.so.0.1.0
b370d000 b371a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b372b000 b3732000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3742000 b3783000 r-xp /usr/lib/libmdm.so.1.2.12
b3793000 b379b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37aa000 b37ba000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37db000 b383b000 r-xp /usr/lib/libasound.so.2.0.0
b384d000 b3850000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3860000 b3863000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3873000 b3878000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3888000 b3889000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3899000 b38a4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38b8000 b38bf000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38cf000 b38d5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38e5000 b38ea000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38fa000 b3915000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3925000 b392c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b393c000 b393f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3950000 b397e000 r-xp /usr/lib/libidn.so.11.5.44
b398e000 b39a4000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39b5000 b39bf000 r-xp /usr/lib/libcares.so.2.1.0
b39cf000 b39d9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39e9000 b39eb000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39fb000 b39fc000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0c000 b3a10000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a21000 b3a49000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a5a000 b3a83000 r-xp /usr/lib/libturbojpeg.so
b3aa3000 b3aa9000 r-xp /usr/lib/libgif.so.4.1.6
b3ab9000 b3aff000 r-xp /usr/lib/libcurl.so.4.3.0
b3b10000 b3b31000 r-xp /usr/lib/libexif.so.12.3.3
b3b4c000 b3b61000 r-xp /usr/lib/libtts.so
b3b72000 b3b7a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b8a000 b3c50000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c70000 b3d68000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d87000 b3e55000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e6c000 b3e6e000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e7e000 b3e84000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e94000 b3eb7000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ec8000 b3eca000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eda000 b3edc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3eed000 b3ef2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f09000 b3f0b000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f1b000 b3f22000 r-xp /usr/lib/libsensord-share.so
b3f32000 b3f4a000 r-xp /usr/lib/libsensor.so.1.1.0
b3f5b000 b3f5e000 r-xp /usr/lib/libXv.so.1.0.0
b3f6e000 b3f73000 r-xp /usr/lib/libutilX.so.1.1.0
b3f83000 b3f88000 r-xp /usr/lib/libappcore-common.so.1.1
b3f98000 b3f9f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fb2000 b3fb6000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fc7000 b40a5000 r-xp /usr/lib/libCOREGL.so.4.0
b40c5000 b40c8000 r-xp /usr/lib/libuuid.so.1.3.0
b40d8000 b40ef000 r-xp /usr/lib/libblkid.so.1.1.0
b4100000 b4102000 r-xp /usr/lib/libXau.so.6.0.0
b4112000 b4159000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b416b000 b4171000 r-xp /usr/lib/libjson-c.so.2.0.1
b4182000 b4186000 r-xp /usr/lib/libogg.so.0.7.1
b4196000 b41b8000 r-xp /usr/lib/libvorbis.so.0.4.3
b41c8000 b42ac000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42c8000 b42cb000 r-xp /usr/lib/libEGL.so.1.4
b42dc000 b42e2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42f2000 b42f4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4304000 b4311000 r-xp /usr/lib/libGLESv2.so.2.0
b4322000 b4384000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4399000 b43b1000 r-xp /usr/lib/libmount.so.1.1.0
b43c3000 b43d7000 r-xp /usr/lib/libxcb.so.1.1.0
b43e7000 b43ee000 r-xp /lib/libcrypt-2.20-2014.11.so
b4426000 b4428000 r-xp /usr/lib/libiri.so
b4438000 b4443000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4454000 b448a000 r-xp /usr/lib/libpulse.so.0.16.2
b449b000 b44de000 r-xp /usr/lib/libsndfile.so.1.0.25
b44f3000 b4508000 r-xp /lib/libexpat.so.1.5.2
b451a000 b45d8000 r-xp /usr/lib/libcairo.so.2.11200.14
b45ec000 b45f4000 r-xp /usr/lib/libdrm.so.2.4.0
b4604000 b4607000 r-xp /usr/lib/libdri2.so.0.0.0
b4617000 b4665000 r-xp /usr/lib/libssl.so.1.0.0
b467a000 b4686000 r-xp /usr/lib/libeeze.so.1.13.0
b4697000 b46a0000 r-xp /usr/lib/libethumb.so.1.13.0
b46b0000 b46b3000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46c3000 b487a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5665000 b566e000 r-xp /usr/lib/libXi.so.6.1.0
b567e000 b5680000 r-xp /usr/lib/libXgesture.so.7.0.0
b5690000 b5694000 r-xp /usr/lib/libXtst.so.6.1.0
b56a4000 b56aa000 r-xp /usr/lib/libXrender.so.1.3.0
b56ba000 b56c0000 r-xp /usr/lib/libXrandr.so.2.2.0
b56d0000 b56d2000 r-xp /usr/lib/libXinerama.so.1.0.0
b56e3000 b56e6000 r-xp /usr/lib/libXfixes.so.3.1.0
b56f6000 b5701000 r-xp /usr/lib/libXext.so.6.4.0
b5711000 b5713000 r-xp /usr/lib/libXdamage.so.1.1.0
b5723000 b5725000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5735000 b5817000 r-xp /usr/lib/libX11.so.6.3.0
b582b000 b5832000 r-xp /usr/lib/libXcursor.so.1.0.2
b5842000 b585a000 r-xp /usr/lib/libudev.so.1.6.0
b585c000 b585f000 r-xp /lib/libattr.so.1.1.0
b586f000 b588f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5890000 b5895000 r-xp /usr/lib/libffi.so.6.0.2
b58a6000 b58be000 r-xp /lib/libz.so.1.2.8
b58ce000 b58d0000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58e0000 b59b5000 r-xp /usr/lib/libxml2.so.2.9.2
b59ca000 b5a65000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a81000 b5a84000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a94000 b5aad000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5abe000 b5acf000 r-xp /lib/libresolv-2.20-2014.11.so
b5ae3000 b5b5d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b72000 b5b74000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b84000 b5b8b000 r-xp /usr/lib/libembryo.so.1.13.0
b5b9b000 b5ba5000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bb6000 b5bce000 r-xp /usr/lib/libpng12.so.0.50.0
b5bdf000 b5c02000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c23000 b5c37000 r-xp /usr/lib/libector.so.1.13.0
b5c48000 b5c60000 r-xp /usr/lib/liblua-5.1.so
b5c71000 b5cc8000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cdc000 b5d04000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d15000 b5d28000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d39000 b5d73000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d84000 b5d92000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5da2000 b5daa000 r-xp /usr/lib/libtbm.so.1.0.0
b5dba000 b5dc7000 r-xp /usr/lib/libeio.so.1.13.0
b5dd7000 b5dd9000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5de9000 b5dee000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dfe000 b5e15000 r-xp /usr/lib/libefreet.so.1.13.0
b5e27000 b5e47000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e57000 b5e77000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e79000 b5e7f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e8f000 b5ea0000 r-xp /usr/lib/libemotion.so.1.13.0
b5eb1000 b5eb8000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ec8000 b5ed7000 r-xp /usr/lib/libeo.so.1.13.0
b5ee8000 b5efa000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f0b000 b5f10000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f20000 b5f39000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f49000 b5f66000 r-xp /usr/lib/libeet.so.1.13.0
b5f7f000 b5fc7000 r-xp /usr/lib/libeina.so.1.13.0
b5fd8000 b5fe8000 r-xp /usr/lib/libefl.so.1.13.0
b5ff9000 b60de000 r-xp /usr/lib/libicuuc.so.51.1
b60fb000 b623b000 r-xp /usr/lib/libicui18n.so.51.1
b6252000 b628a000 r-xp /usr/lib/libecore_x.so.1.13.0
b629c000 b629f000 r-xp /lib/libcap.so.2.21
b62af000 b62d8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62e9000 b62f0000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6302000 b6339000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b634a000 b6435000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6448000 b64c1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64d3000 b64d8000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64e8000 b64f2000 r-xp /usr/lib/libvconf.so.0.2.45
b6502000 b6504000 r-xp /usr/lib/libvasum.so.0.3.1
b6514000 b6516000 r-xp /usr/lib/libttrace.so.1.1
b6526000 b6529000 r-xp /usr/lib/libiniparser.so.0
b6539000 b655f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b656f000 b6574000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6585000 b659c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65ad000 b6618000 r-xp /lib/libm-2.20-2014.11.so
b6629000 b662f000 r-xp /lib/librt-2.20-2014.11.so
b6640000 b664d000 r-xp /usr/lib/libunwind.so.8.0.1
b6683000 b67a7000 r-xp /lib/libc-2.20-2014.11.so
b67bc000 b67d5000 r-xp /lib/libgcc_s-4.9.so.1
b67e5000 b68c7000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68d8000 b6902000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6913000 b694f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6951000 b69d4000 r-xp /usr/lib/libedje.so.1.13.0
b69e7000 b6a05000 r-xp /usr/lib/libecore.so.1.13.0
b6a25000 b6bac000 r-xp /usr/lib/libevas.so.1.13.0
b6be1000 b6bf5000 r-xp /lib/libpthread-2.20-2014.11.so
b6c09000 b6e3d000 r-xp /usr/lib/libelementary.so.1.13.0
b6e6c000 b6e70000 r-xp /usr/lib/libsmack.so.1.0.0
b6e80000 b6e87000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e97000 b6e99000 r-xp /usr/lib/libdlog.so.0.0.0
b6ea9000 b6eac000 r-xp /usr/lib/libbundle.so.0.1.22
b6ebc000 b6ebe000 r-xp /lib/libdl-2.20-2014.11.so
b6ecf000 b6ee7000 r-xp /usr/lib/libaul.so.0.1.0
b6efb000 b6f00000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f11000 b6f1e000 r-xp /usr/lib/liblptcp.so
b6f30000 b6f34000 r-xp /usr/lib/libsys-assert.so
b6f45000 b6f65000 r-xp /lib/ld-2.20-2014.11.so
b6f76000 b6f7b000 r-xp /usr/bin/launchpad-loader
b85eb000 b89e6000 rw-p [heap]
beb16000 beb37000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1504)
Call Stack Count: 21
 0: memo_view_cb + 0x17 (0xb27f9b04) [/opt/usr/apps/org.example.goldlucks/bin/goldlucks] + 0x2b04
 1: (0xb6c819a3) [/usr/lib/libelementary.so.1] + 0x789a3
 2: (0xb6a8b7ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb5ed3219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5ed1fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6a8cedd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb69a8167) [/usr/lib/libedje.so.1] + 0x57167
 7: (0xb69acd87) [/usr/lib/libedje.so.1] + 0x5bd87
 8: (0xb69a8b21) [/usr/lib/libedje.so.1] + 0x57b21
 9: (0xb69a8ef1) [/usr/lib/libedje.so.1] + 0x57ef1
10: (0xb69a9045) [/usr/lib/libedje.so.1] + 0x58045
11: (0xb69f6d11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb69f2c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69f8a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb69f8c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6efe2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb3fb4909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: main + 0x110 (0xb27f8e99) [/opt/usr/apps/org.example.goldlucks/bin/goldlucks] + 0x1e99
18: (0xb6f77bb5) [/opt/usr/apps/org.example.goldlucks/bin/goldlucks] + 0x1bb5
19: __libc_start_main + 0x114 (0xb66994bc) [/lib/libc.so.6] + 0x164bc
20: main + 0x12b (0xb6f77eb4) [/opt/usr/apps/org.example.goldlucks/bin/goldlucks] + 0x1eb4
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
ol.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
08-22 14:05:03.343+0900 E/QUICKPANEL(  859): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
08-22 14:05:03.343+0900 E/QUICKPANEL(  859): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
08-22 14:05:03.343+0900 E/QUICKPANEL(  859): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
08-22 14:05:03.343+0900 I/QUICKPANEL(  859): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
08-22 14:05:03.343+0900 W/QUICKPANEL(  859): NotificationItemModel.cpp: insertNotification(249) > [0;35mOngoing notification is inserted.[0;m
08-22 14:05:03.353+0900 E/EFL     (  859): eo<859> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
08-22 14:05:03.353+0900 I/QUICKPANEL(  859): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(719) > [0;35m* Info * Lets check ongoing request....[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_task_manager.c: __release_power_lock(668) > [0;35m* Info * No Ongoing Task[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_task_manager.c: __release_power_lock(670) > [0;35m* Info * power lock is already released![0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_main.c: ___g_destroy_timer_expire_cb(179) > [0;35m* Info * Destory Cloud content sync as there is no task ongoing....[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(610) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(610) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(610) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(610) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
08-22 14:05:15.135+0900 E/CLOUD_CONTENT_SYNC_COMMON( 1462): cs_common.c: _common_get_hash_table_size(165) > [0;31m* Critical * Invalid params[0;m
08-22 14:05:15.135+0900 E/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_notification_manager.c: _server_noti_manager_destroy(1722) > [0;31m* Critical * invalid req_thread[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_main.c: _cloud_content_sync_deactivate(166) > [0;35m* Info * exiting cloud-content-sync-server[0;m
08-22 14:05:15.135+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_main.c: __init_cloud_content_sync(334) > [0;35m* Info * -------------------- Exit cloud server ------------------[0;m
08-22 14:05:15.145+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_task_manager.c: __event_handler(324) > [0;35m* Info * Dummy Request - break from loop [0;m
08-22 14:05:15.145+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1462): media_content.c: media_content_disconnect(940) > [32m[1462]ref count changed to: 0
08-22 14:05:15.145+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1462): cs_server_dispatch_manager.c: _server_dispatch_manager_deinit(531) > [0;35m* Info * wait at join[0;m
08-22 14:05:15.145+0900 I/CLOUD_CONTENT_SYNC_TRANS( 1462): cs_transport_async_req_handler.c: __event_handler(112) > [0;35m* Info * Dummy Request - break from loop [0;m
08-22 14:05:15.145+0900 I/CAPI_NETWORK_CONNECTION( 1462): connection.c: connection_destroy(427) > Destroy handle: 0xb827ff20
08-22 14:05:15.145+0900 I/CAPI_NETWORK_CONNECTION( 1462): connection.c: __connection_set_type_changed_callback(181) > Successfully de-registered(0)
08-22 14:05:15.145+0900 I/CAPI_NETWORK_CONNECTION( 1462): connection.c: __connection_set_proxy_changed_callback(351) > Successfully de-registered(0)
08-22 14:05:15.165+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
08-22 14:05:15.165+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 7
08-22 14:05:15.165+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
08-22 14:05:15.165+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
08-22 14:05:15.325+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
08-22 14:05:15.325+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1462
08-22 14:05:15.325+0900 E/AUL_AMD (  610): amd_launch.c: _amd_proc_remove_proc_info(1947) > proc info not found
08-22 14:05:15.335+0900 I/Tizen::App( 1318): (243) > App[com.samsung.cloud-content-sync] pid[1462] terminate event is forwarded
08-22 14:05:15.335+0900 I/Tizen::System( 1318): (256) > osp.accessorymanager.service provider is found.
08-22 14:05:15.335+0900 I/Tizen::System( 1318): (196) > Accessory Owner is removed [com.samsung.cloud-content-sync, 1462, ]
08-22 14:05:15.335+0900 I/Tizen::System( 1318): (256) > osp.system.service provider is found.
08-22 14:05:15.335+0900 I/Tizen::App( 1318): (506) > TerminatedApp(com.samsung.cloud-content-sync)
08-22 14:05:15.335+0900 I/Tizen::App( 1318): (512) > Not registered pid(1462)
08-22 14:05:15.335+0900 I/Tizen::System( 1318): (246) > Terminated app [com.samsung.cloud-content-sync]
08-22 14:05:15.335+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 14:05:15.335+0900 I/ESD     (  877): esd_main.c: __esd_app_dead_handler(1773) > pid: 1462
08-22 14:05:15.335+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 14:05:15.335+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 14:05:15.335+0900 I/Tizen::App( 1318): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync, 1462.
08-22 14:05:20.170+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
08-22 14:05:25.795+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=101602
08-22 14:05:25.935+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=101743
08-22 14:05:26.196+0900 W/cluster-view(  860): custom-cluster-impl.cpp: OnCustomScrollComplete(8717) >  booster timer is still running on cluster-view, Stop boost timer!!!
08-22 14:05:26.256+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __provider_pause_cb(304) > widget obj was paused
08-22 14:05:26.256+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __check_status_for_cgroup(152) > enter background group
08-22 14:05:26.256+0900 W/AUL     ( 1393): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1393, appid: com.samsung.weather-m-widget, status: bg
08-22 14:05:26.436+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=102239
08-22 14:05:26.486+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=102292
08-22 14:05:26.496+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
08-22 14:05:26.516+0900 E/weather-widget( 1393): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
08-22 14:05:26.526+0900 E/weather-common( 1393): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
08-22 14:05:26.576+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_create(409) > New handle created[0xb8043708]
08-22 14:05:26.576+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_get_type(463) > Connected Network = 0
08-22 14:05:26.576+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
08-22 14:05:26.576+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
08-22 14:05:26.576+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_destroy(427) > Destroy handle: 0xb8043708
08-22 14:05:26.576+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
08-22 14:05:26.576+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
08-22 14:05:26.576+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
08-22 14:05:26.576+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
08-22 14:05:26.576+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
08-22 14:05:26.576+0900 W/AUL     ( 1393): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1393, appid: com.samsung.weather-m-widget, status: fg
08-22 14:05:26.746+0900 W/cluster-view(  860): custom-cluster-impl.cpp: OnCustomScrollComplete(8717) >  booster timer is still running on cluster-view, Stop boost timer!!!
08-22 14:05:26.966+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=102773
08-22 14:05:26.996+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
08-22 14:05:26.996+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
08-22 14:05:27.026+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __provider_pause_cb(304) > widget obj was paused
08-22 14:05:27.026+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __check_status_for_cgroup(152) > enter background group
08-22 14:05:27.026+0900 W/AUL     ( 1393): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1393, appid: com.samsung.weather-m-widget, status: bg
08-22 14:05:27.046+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=102849
08-22 14:05:27.267+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
08-22 14:05:27.267+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
08-22 14:05:27.267+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnFocusedViewChanged(4344) >  view type is not chaged,same view[0]
08-22 14:05:27.277+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
08-22 14:05:27.297+0900 E/weather-widget( 1393): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
08-22 14:05:27.307+0900 E/weather-common( 1393): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
08-22 14:05:27.357+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_create(409) > New handle created[0xb807e6d0]
08-22 14:05:27.357+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_get_type(463) > Connected Network = 0
08-22 14:05:27.357+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(143) > [0;40;31mconnection type disconnected or bt connection[0;m
08-22 14:05:27.357+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(144) > [0;40;31mnetwork connection type:0[0;m
08-22 14:05:27.357+0900 I/CAPI_NETWORK_CONNECTION( 1393): connection.c: connection_destroy(427) > Destroy handle: 0xb807e6d0
08-22 14:05:27.357+0900 E/weather-common( 1393): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:0[0;m
08-22 14:05:27.357+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(607) > [0;40;31mIsNetworkAvailable failed[0;m
08-22 14:05:27.357+0900 E/weather-widget( 1393): WidgetMain.cpp: ResumeWidgetInstance(610) > [0;40;31m[ResumeWidgetInstance(): 610] (checkLocationAndNetwork == false) [break][0;m
08-22 14:05:27.357+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
08-22 14:05:27.357+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
08-22 14:05:27.357+0900 W/AUL     ( 1393): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1393, appid: com.samsung.weather-m-widget, status: fg
08-22 14:05:27.667+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=103478
08-22 14:05:27.717+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
08-22 14:05:27.717+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
08-22 14:05:27.737+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __provider_pause_cb(304) > widget obj was paused
08-22 14:05:27.737+0900 I/CAPI_WIDGET_APPLICATION( 1393): widget_app.c: __check_status_for_cgroup(152) > enter background group
08-22 14:05:27.737+0900 W/AUL     ( 1393): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1393, appid: com.samsung.weather-m-widget, status: bg
08-22 14:05:28.027+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=103836
08-22 14:05:28.678+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=104480
08-22 14:05:28.798+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=104599
08-22 14:05:29.068+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
08-22 14:05:29.679+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=105482
08-22 14:05:30.239+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=106046
08-22 14:05:30.510+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
08-22 14:05:32.311+0900 E/PKGMGR  ( 1713): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
08-22 14:05:32.392+0900 E/PKGMGR_SERVER( 1715): pkgmgr-server.c: main(2414) > package manager server start
08-22 14:05:32.442+0900 E/PKGMGR_SERVER( 1715): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.goldlucks-1.0.0-arm.tpk]
08-22 14:05:32.452+0900 E/PKGMGR_INFO( 1715): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.goldlucks-1.0.0-arm.tpk] not found in DB
08-22 14:05:32.452+0900 E/rpm-installer( 1715): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
08-22 14:05:32.462+0900 E/PKGMGR_SERVER( 1715): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
08-22 14:05:32.462+0900 E/PKGMGR_SERVER( 1715): pkgmgr-server.c: __set_recovery_mode(234) > rev_file[/opt/share/packages/.recovery/pkgmgr/org.example.goldlucks-1.0.0-arm.tpk] is null
08-22 14:05:32.462+0900 E/PKGMGR  ( 1713): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[17130002]
08-22 14:05:32.602+0900 E/PKGMGR_INSTALLER( 1718): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
08-22 14:05:32.612+0900 E/rpm-installer( 1718): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.goldlucks-1.0.0-arm.tpk] is tpk package.
08-22 14:05:32.632+0900 E/rpm-installer( 1718): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
08-22 14:05:32.632+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
08-22 14:05:32.632+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_get_value_list(1104) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
08-22 14:05:32.632+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
08-22 14:05:32.632+0900 E/rpm-installer( 1718): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
08-22 14:05:32.632+0900 E/rpm-installer( 1718): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
08-22 14:05:32.692+0900 W/CERT_SVC_VCORE( 1718): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
08-22 14:05:32.752+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: start, val: install
08-22 14:05:32.752+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [start], Value = [install], install = [1]
08-22 14:05:32.762+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: install_percent, val: 30
08-22 14:05:32.762+0900 I/Tizen::App( 1318): (119) > InstallationInProgress [30]
08-22 14:05:32.762+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [install_percent], Value = [30], install = [1]
08-22 14:05:32.852+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
08-22 14:05:32.852+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
08-22 14:05:32.862+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
08-22 14:05:32.862+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
08-22 14:05:32.862+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
08-22 14:05:32.862+0900 E/rpm-installer( 1718): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
08-22 14:05:32.862+0900 E/PKGMGR_PARSER( 1718): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
08-22 14:05:32.872+0900 E/PKGMGR_PARSER( 1718): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
08-22 14:05:33.112+0900 E/PKGMGR_PARSER( 1718): pkgmgr_parser.c: __check_theme(142) > theme for installation.
08-22 14:05:33.202+0900 E/PKGMGR_CERT( 1718): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
08-22 14:05:33.202+0900 E/PKGMGR_CERT( 1718): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 113
08-22 14:05:33.202+0900 E/PKGMGR_CERT( 1718): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 113
08-22 14:05:33.212+0900 E/PKGMGR_CERT( 1718): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
08-22 14:05:33.212+0900 E/PKGMGR_CERT( 1718): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 33 7
08-22 14:05:33.212+0900 E/PKGMGR_CERT( 1718): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 34 7
08-22 14:05:33.212+0900 E/PKGMGR_CERT( 1718): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 37 2
08-22 14:05:33.212+0900 E/PKGMGR_CERT( 1718): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
08-22 14:05:33.222+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: install_percent, val: 60
08-22 14:05:33.222+0900 I/Tizen::App( 1318): (119) > InstallationInProgress [60]
08-22 14:05:33.222+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [install_percent], Value = [60], install = [1]
08-22 14:05:33.242+0900 E/rpm-installer( 1718): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
08-22 14:05:33.262+0900 E/rpm-installer( 1718): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
08-22 14:05:33.262+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: install_percent, val: 100
08-22 14:05:33.262+0900 I/Tizen::App( 1318): (119) > InstallationInProgress [100]
08-22 14:05:33.262+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [install_percent], Value = [100], install = [1]
08-22 14:05:35.184+0900 I/Tizen::App( 1318): (1894) > PackageEventHandler - req: 13180002, pkg_type: tpk, pkg_name: org.example.goldlucks, key: end, val: ok
08-22 14:05:35.184+0900 I/Tizen::App( 1318): (78) > Installation is Completed. [Package = org.example.goldlucks]
08-22 14:05:35.184+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
08-22 14:05:35.184+0900 I/Tizen::App( 1318): (671) > Enter. package(org.example.goldlucks), installationResult(0)
08-22 14:05:35.184+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
08-22 14:05:35.184+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
08-22 14:05:35.194+0900 E/PKGMGR_INFO( 1318): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(1119) > (_pkgmgrinfo_pkginfo_get_theme_icon(handle, icon) == PMINFO_R_OK) theme_ico(org.example.goldlucks) is found
08-22 14:05:35.194+0900 E/PKGMGR_SERVER( 1715): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
08-22 14:05:35.194+0900 I/Tizen::App( 1318): (1360) > package(org.example.goldlucks), version(1.0.0), type(tpk), displayName(goldlucks), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.goldlucks), storeClient(), appRootPath(/opt/usr/apps/org.example.goldlucks)
08-22 14:05:35.204+0900 I/Tizen::App( 1318): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.goldlucks]
08-22 14:05:35.224+0900 I/Tizen::App( 1318): (416) > appName = [goldlucks]
08-22 14:05:35.224+0900 E/PKGMGR_INFO( 1318): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1914) > (_pkgmgrinfo_appinfo_get_theme_icon(handle, icon) == PMINFO_R_OK) theme_ico(org.example.goldlucks) is found
08-22 14:05:35.224+0900 I/Tizen::App( 1318): (509) > exe = [/opt/usr/apps/org.example.goldlucks/bin/goldlucks], displayName = [goldlucks], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-22 14:05:35.224+0900 E/PKGMGR_INFO( 1318): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
08-22 14:05:35.224+0900 I/Tizen::App( 1318): (683) > Application count(1) in this package
08-22 14:05:35.224+0900 I/Tizen::App( 1318): (840) > Enter.
08-22 14:05:35.224+0900 I/Tizen::App( 1318): (703) > Exit.
08-22 14:05:35.224+0900 I/Tizen::App( 1318): (1584) > Package = [org.example.goldlucks], Key = [end], Value = [ok], install = [1]
08-22 14:05:35.234+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.goldlucks]
08-22 14:05:35.234+0900 E/PKGMGR_SERVER( 1715): pkgmgr-server.c: __unset_recovery_mode(282) > remove recovery_file[/opt/share/packages/.recovery/pkgmgr/org.example.goldlucks-1.0.0-arm.tpk] fail
08-22 14:05:35.234+0900 E/PKGMGR_SERVER( 1715): pkgmgr-server.c: sighandler(417) > child NORMAL exit [1718]
08-22 14:05:35.234+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.goldlucks]
08-22 14:05:35.234+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
08-22 14:05:35.234+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
08-22 14:05:35.234+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.goldlucks]
08-22 14:05:35.244+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
08-22 14:05:35.244+0900 I/Tizen::App( 1318): (416) > appName = [goldlucks]
08-22 14:05:35.244+0900 E/PKGMGR_INFO( 1318): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1914) > (_pkgmgrinfo_appinfo_get_theme_icon(handle, icon) == PMINFO_R_OK) theme_ico(org.example.goldlucks) is found
08-22 14:05:35.244+0900 I/Tizen::App( 1318): (509) > exe = [/opt/usr/apps/org.example.goldlucks/bin/goldlucks], displayName = [goldlucks], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-22 14:05:35.244+0900 I/Tizen::App( 1318): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.goldlucks.info]
08-22 14:05:35.244+0900 I/Tizen::App( 1318): (131) > Enter
08-22 14:05:35.254+0900 I/Tizen::App( 1318): (137) > org.example.goldlucks does not have launch condition
08-22 14:05:35.254+0900 I/Tizen::App( 1318): (883) > Exit.
08-22 14:05:35.254+0900 E/PKGMGR_INFO(  860): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1914) > (_pkgmgrinfo_appinfo_get_theme_icon(handle, icon) == PMINFO_R_OK) theme_ico(org.example.goldlucks) is found
08-22 14:05:35.254+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[goldlucks] enable[1] system[0]
08-22 14:05:35.254+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.goldlucks] mdm is not enabled
08-22 14:05:35.274+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.goldlucks]
08-22 14:05:35.284+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[goldlucks] enable[1] system[0]
08-22 14:05:35.284+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
08-22 14:05:35.284+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
08-22 14:05:35.304+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/data/theme/icon/app/org.example.goldlucks.png], Loading state:[1]
08-22 14:05:37.196+0900 E/PKGMGR_SERVER( 1715): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-22 14:05:37.196+0900 E/PKGMGR_SERVER( 1715): pkgmgr-server.c: main(2471) > package manager server terminated.
08-22 14:05:37.276+0900 I/SERVICE_MANAGER_LIB(  961): service-manager.c: service_manager_unregister_listener2(564) > [34m[961]service_manager_unregister_object[0m
08-22 14:05:38.538+0900 W/AUL_AMD (  610): amd_main.c: __platform_ready_handler(491) > [Info]__platform_ready_handler
08-22 14:05:41.571+0900 W/AUL     ( 1774): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.goldlucks)
08-22 14:05:41.581+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
08-22 14:05:41.581+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
08-22 14:05:41.591+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
08-22 14:05:41.591+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
08-22 14:05:41.591+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1774
08-22 14:05:41.591+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
08-22 14:05:41.601+0900 E/RESOURCED(  666): block.c: block_prelaunch_state(134) > insert data org.example.goldlucks, table num : 4
08-22 14:05:41.601+0900 E/RESOURCED(  666): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
08-22 14:05:41.601+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
08-22 14:05:41.601+0900 W/AUL_PAD ( 1502): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
08-22 14:05:41.601+0900 W/AUL_PAD ( 1502): launchpad.c: __send_result_to_caller(267) > Check app launching
08-22 14:05:41.621+0900 I/CAPI_APPFW_APPLICATION( 1504): app_main.c: ui_app_main(789) > app_efl_main
08-22 14:05:41.621+0900 I/CAPI_APPFW_APPLICATION( 1504): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
08-22 14:05:41.651+0900 E/TBM     ( 1504): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
08-22 14:05:41.701+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 1504, appid: org.example.goldlucks
08-22 14:05:41.701+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
08-22 14:05:41.701+0900 W/AUL     ( 1774): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1504)
08-22 14:05:41.711+0900 E/RESOURCED(  666): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.goldlucks
08-22 14:05:41.711+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 14:05:41.711+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 14:05:41.711+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 14:05:41.711+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 14:05:41.881+0900 I/APP_CORE( 1504): appcore-efl.c: __do_app(514) > [APP 1504] Event: RESET State: CREATED
08-22 14:05:41.881+0900 I/CAPI_APPFW_APPLICATION( 1504): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
08-22 14:05:41.881+0900 E/EFL     ( 1504): edje<1504> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-22 14:05:41.881+0900 E/EFL     ( 1504): By the power of Grayskull, your previous Embryo stack is now broken!
08-22 14:05:41.891+0900 E/EFL     ( 1504): edje<1504> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-22 14:05:41.891+0900 E/EFL     ( 1504): By the power of Grayskull, your previous Embryo stack is now broken!
08-22 14:05:41.891+0900 E/EFL     ( 1504): edje<1504> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
08-22 14:05:41.891+0900 E/EFL     ( 1504): By the power of Grayskull, your previous Embryo stack is now broken!
08-22 14:05:41.911+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 14:05:41.911+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 14:05:41.941+0900 I/Tizen::System( 1318): (259) > Active app [org.exampl], current [com.samsun] 
08-22 14:05:41.941+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 14:05:41.941+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
08-22 14:05:41.941+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 14:05:41.961+0900 W/APP_CORE( 1504): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5a00002
08-22 14:05:41.961+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
08-22 14:05:41.961+0900 E/EFL     ( 1504): elementary<1504> elm_scroller.c:1094 elm_scroller_page_size_set() The object ((nil)) doesn't implement the Elementary scrollable interface
08-22 14:05:42.041+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
08-22 14:05:42.041+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
08-22 14:05:42.041+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
08-22 14:05:42.051+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
08-22 14:05:42.051+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
08-22 14:05:42.051+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
08-22 14:05:42.051+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1504) status(3)
08-22 14:05:42.051+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-22 14:05:42.051+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
08-22 14:05:42.051+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.goldlucks(1504)
08-22 14:05:42.051+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1504, appid: org.example.goldlucks, status: fg
08-22 14:05:42.111+0900 I/APP_CORE( 1504): appcore-efl.c: __do_app(514) > [APP 1504] Event: RESUME State: CREATED
08-22 14:05:42.121+0900 I/APP_CORE( 1504): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
08-22 14:05:42.121+0900 I/APP_CORE( 1504): appcore-efl.c: __do_app(625) > [APP 1504] Initial Launching, call the resume_cb
08-22 14:05:42.121+0900 I/CAPI_APPFW_APPLICATION( 1504): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-22 14:05:42.141+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 14:05:42.141+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 14:05:42.141+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 14:05:42.141+0900 E/RESOURCED(  666): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
08-22 14:05:42.421+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1504) status(0)
08-22 14:05:42.742+0900 I/Tizen::App( 1318): (499) > LaunchedApp(org.example.goldlucks)
08-22 14:05:42.742+0900 I/Tizen::App( 1318): (733) > Finished invoking application event listener for org.example.goldlucks, 1504.
08-22 14:05:42.752+0900 E/RESOURCED(  666): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.240
08-22 14:05:43.512+0900 I/UXT     ( 1783): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
08-22 14:05:44.163+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=119977
08-22 14:05:44.253+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=120031
08-22 14:05:44.253+0900 E/VCONF   ( 1504): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
08-22 14:05:44.253+0900 E/VCONF   ( 1504): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
08-22 14:05:44.253+0900 E/VCONF   ( 1504): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
08-22 14:05:44.253+0900 E/VCONF   ( 1504): vconf.c: vconf_get_bool(2729) > vconf_get_bool(1504) : db/ise/keysound error
08-22 14:05:44.253+0900 E/VCONF   ( 1504): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
08-22 14:05:44.253+0900 E/VCONF   ( 1504): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
08-22 14:05:45.104+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=120912
08-22 14:05:45.164+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=120977
08-22 14:05:45.484+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=121295
08-22 14:05:45.534+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=121339
08-22 14:05:45.534+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb888a230 is not pointing to a valid object. Maybe it has already been freed.
08-22 14:05:45.534+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb888a230) is an invalid ref.
08-22 14:05:47.056+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
08-22 14:05:47.927+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=123732
08-22 14:05:47.987+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=123797
08-22 14:05:48.007+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x80092294's acvie is  NULL, entry: 0xb33434a8, 0xb88235f0, 0
08-22 14:05:48.007+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x80092294 is not pointing to a valid object. Maybe it has already been freed.
08-22 14:05:48.007+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x80092294) is an invalid ref.
08-22 14:05:50.990+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126795
08-22 14:05:51.040+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126850
08-22 14:05:51.040+0900 E/EFL     ( 1504): elementary<1504> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
08-22 14:05:51.841+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127653
08-22 14:05:51.901+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127718
08-22 14:05:51.911+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb888a230 is not pointing to a valid object. Maybe it has already been freed.
08-22 14:05:51.911+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb888a230) is an invalid ref.
08-22 14:05:52.501+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=128314
08-22 14:05:52.571+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=128378
08-22 14:05:52.591+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x800d309c's acvie is  NULL, entry: 0xb33444e0, 0xb88235f0, 0
08-22 14:05:52.591+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x800d309c is not pointing to a valid object. Maybe it has already been freed.
08-22 14:05:52.591+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x800d309c) is an invalid ref.
08-22 14:05:53.482+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=129291
08-22 14:05:53.562+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=129366
08-22 14:05:53.562+0900 E/EFL     ( 1504): elementary<1504> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
08-22 14:05:54.473+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=130280
08-22 14:05:54.533+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=130335
08-22 14:05:54.543+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb888a230 is not pointing to a valid object. Maybe it has already been freed.
08-22 14:05:54.543+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb888a230) is an invalid ref.
08-22 14:05:55.694+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=131497
08-22 14:05:55.764+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=131573
08-22 14:05:55.784+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x8011349f's acvie is  NULL, entry: 0xb33454f0, 0xb88106e0, 0
08-22 14:05:55.784+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x8011349f is not pointing to a valid object. Maybe it has already been freed.
08-22 14:05:55.784+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x8011349f) is an invalid ref.
08-22 14:05:56.835+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132643
08-22 14:05:56.875+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132686
08-22 14:05:56.885+0900 E/EFL     ( 1504): elementary<1504> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
08-22 14:05:57.626+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=133435
08-22 14:05:57.706+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=133510
08-22 14:05:57.706+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0xb888a230 is not pointing to a valid object. Maybe it has already been freed.
08-22 14:05:57.706+0900 E/EFL     ( 1504): eo<1504> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb888a230) is an invalid ref.
08-22 14:05:58.317+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=134126
08-22 14:05:58.427+0900 E/EFL     ( 1504): ecore_x<1504> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=134234
08-22 14:05:58.597+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 14:05:58.607+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
08-22 14:05:58.607+0900 I/AUL_PAD ( 1502): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 1504 pgid = 1504
08-22 14:05:58.607+0900 I/AUL_PAD ( 1502): sigchild.h: __sigchild_action(143) > dead_pid(1504)
08-22 14:05:58.607+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
08-22 14:05:58.607+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
08-22 14:05:58.607+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
08-22 14:05:58.607+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
08-22 14:05:58.637+0900 I/AUL_PAD ( 1502): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
08-22 14:05:58.637+0900 I/AUL_PAD ( 1502): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
08-22 14:05:58.637+0900 E/AUL_PAD ( 1502): launchpad.c: main(698) > error reading sigchld info
08-22 14:05:58.647+0900 I/ESD     (  877): esd_main.c: __esd_app_dead_handler(1773) > pid: 1504
08-22 14:05:58.647+0900 I/Tizen::App( 1318): (243) > App[org.example.goldlucks] pid[1504] terminate event is forwarded
08-22 14:05:58.647+0900 I/Tizen::System( 1318): (256) > osp.accessorymanager.service provider is found.
08-22 14:05:58.647+0900 I/Tizen::System( 1318): (196) > Accessory Owner is removed [org.example.goldlucks, 1504, ]
08-22 14:05:58.647+0900 I/Tizen::System( 1318): (256) > osp.system.service provider is found.
08-22 14:05:58.647+0900 I/Tizen::App( 1318): (506) > TerminatedApp(org.example.goldlucks)
08-22 14:05:58.647+0900 I/Tizen::App( 1318): (512) > Not registered pid(1504)
08-22 14:05:58.647+0900 I/Tizen::System( 1318): (246) > Terminated app [org.example.goldlucks]
08-22 14:05:58.647+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 14:05:58.647+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1504
08-22 14:05:58.647+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 1504
08-22 14:05:58.647+0900 E/RESOURCED(  666): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.244
08-22 14:05:58.667+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
08-22 14:05:58.667+0900 E/RESOURCED(  666): iface.c: lookup_ifname(355) > Please provide valid argument!
08-22 14:05:58.667+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 14:05:58.667+0900 I/Tizen::App( 1318): (782) > Finished invoking application event listener for org.example.goldlucks, 1504.
08-22 14:05:58.677+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
08-22 14:05:58.677+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
08-22 14:05:58.677+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
08-22 14:05:58.687+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
08-22 14:05:58.717+0900 I/Tizen::System( 1318): (259) > Active app [com.samsun], current [org.exampl] 
08-22 14:05:58.717+0900 I/Tizen::Io( 1318): (729) > Entry not found
08-22 14:05:58.747+0900 I/TIZEN_N_SOUND_MANAGER(  896): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
08-22 14:05:58.747+0900 E/TIZEN_N_SOUND_MANAGER(  896): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-22 14:05:58.747+0900 I/Tizen::System( 1318): (157) > change brightness system value.
08-22 14:05:58.747+0900 I/TIZEN_N_SOUND_MANAGER(  896): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
08-22 14:05:58.747+0900 E/TIZEN_N_SOUND_MANAGER(  896): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
08-22 14:05:58.747+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
08-22 14:05:58.767+0900 W/CRASH_MANAGER( 1791): worker.c: worker_job(1199) > 1101504676f6c147184235
