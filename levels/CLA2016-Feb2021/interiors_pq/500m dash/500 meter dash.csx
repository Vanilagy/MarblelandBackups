<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2018/09/22 18:01:47">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="552">
                    <Brush id="3" owner="0" type="0" pos="0 0 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1927" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="1920" plane="1 -0 0 -2" album="PQ" material="pq_hot_1_med" texgens="0 1 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1921" plane="-1 0 0 -2" album="PQ" material="pq_hot_1_med" texgens="0 -1 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1922" plane="0 1 -0 -2" album="PQ" material="pq_hot_1_med" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1923" plane="0 -1 0 -2" album="PQ" material="pq_hot_1_med" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1924" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_1_med" texgens="1 0 0 128 0 -1 0 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1925" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 -1 0 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-3 0 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 0 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="1 -0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 -0 -4" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="3 0 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 0 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="1 -0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 -0 -4" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="0 8 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1393" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="1386" plane="1 -0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1387" plane="-1 0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1388" plane="0 1 -0 -6" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1389" plane="0 -1 0 -6" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1390" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1391" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="0 -3 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="847" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="840" plane="1 -0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 1 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="841" plane="-1 0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="842" plane="0 1 -0 -1" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="843" plane="0 -1 0 -1" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="844" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 -1 0 -64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="845" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 -1 0 -64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-0.25 -4.25 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -0.25 0 1 0 -4.25 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1147" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.25 0.25" />
                            <Vertex pos="4.25 0.25 -0.25" />
                            <Vertex pos="4.25 -0.25 0.25" />
                            <Vertex pos="4.25 -0.25 -0.25" />
                            <Vertex pos="-4.25 0.25 0.25" />
                            <Vertex pos="-4.25 0.25 -0.25" />
                            <Vertex pos="-4.25 -0.25 0.25" />
                            <Vertex pos="-4.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="1140" plane="1 -0 0 -4.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1141" plane="-1 0 0 -4.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1142" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 272 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1143" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 272 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1144" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 272 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1145" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 272 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-4.25 0 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 0 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="432" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="433" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="434" plane="0 1 -0 -4" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="435" plane="0 -1 0 -4" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="436" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="437" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="4.25 0 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 0 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4.5 0.25" />
                            <Vertex pos="0.25 -4.5 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4.5 0.25" />
                            <Vertex pos="-0.25 -4.5 -0.25" />
                        </Vertices>
                        <Face id="432" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="433" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="434" plane="0 1 -0 -4" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="435" plane="0 -1 0 -4.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="436" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="437" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-3 8 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 8 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0.25" />
                            <Vertex pos="1 6 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="1 6 0.25" />
                            <Vertex pos="1 6 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="1 -0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-0.980581 0.196116 0 -0.196116" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 0 -6" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="3 8 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 8 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 6 0.25" />
                            <Vertex pos="-1 6 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 6 0.25" />
                            <Vertex pos="-1 6 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="0.980581 0.196116 0 -0.196116" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 0 -6" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-4.25 8 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 8 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 6 0.25" />
                            <Vertex pos="2.25 6 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="1.75 6 0.25" />
                            <Vertex pos="1.75 6 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="432" plane="0.980581 -0.196116 0 -1.02961" album="PQ" material="pq_wood_2" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="433" plane="-0.980581 0.196116 0 0.539319" album="PQ" material="pq_wood_2" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="434" plane="0 1 -0 -6" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="435" plane="0 -1 0 -4" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="436" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="437" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="4.25 8 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 8 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 6 0.25" />
                            <Vertex pos="-1.75 6 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-2.25 6 0.25" />
                            <Vertex pos="-2.25 6 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="432" plane="0.980581 0.196116 0 0.539319" album="PQ" material="pq_wood_2" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="433" plane="-0.980581 -0.196116 0 -1.02961" album="PQ" material="pq_wood_2" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="434" plane="0 1 -0 -6" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="435" plane="0 -1 0 -4" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="436" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="437" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="0 14.25 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 14.25 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="655" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="648" plane="0.707107 0.707107 0 -1.59099" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="649" plane="-0.707107 0.707107 0 -1.59099" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="650" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="651" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="652" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 160 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="653" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 160 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-4.25 -4.25 4" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 -4.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="505" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3.5" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 3.5" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 3.5" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 -0.25 3.5" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="498" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="499" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="500" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="501" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="502" plane="-0 0 1 -3.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="503" plane="0 0 -1 -4" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="4.25 -4.25 4" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 -4.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="505" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3.5" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 3.5" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 3.5" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 -0.25 3.5" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="498" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="499" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="500" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="501" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="502" plane="-0 0 1 -3.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="503" plane="0 0 -1 -4" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-4.25 3.75 4" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 3.75 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="505" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3.5" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 3.5" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 3.5" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 -0.25 3.5" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="498" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="499" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="500" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="501" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="502" plane="-0 0 1 -3.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="503" plane="0 0 -1 -4" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="4.25 3.75 4" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 3.75 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="505" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3.5" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 3.5" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 3.5" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 -0.25 3.5" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="498" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="499" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="500" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="501" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="502" plane="-0 0 1 -3.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="503" plane="0 0 -1 -4" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-3 0 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 0 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="1 -0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 -0 -4" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="0 -3 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="847" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="840" plane="1 -0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 1 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="841" plane="-1 0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="842" plane="0 1 -0 -1" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="843" plane="0 -1 0 -1" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="844" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 -1 0 -64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="845" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 -1 0 -64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="0 0 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="1927" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="1920" plane="1 -0 0 -2" album="PQ" material="pq_hot_1_med" texgens="0 1 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1921" plane="-1 0 0 -2" album="PQ" material="pq_hot_1_med" texgens="0 -1 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1922" plane="0 1 -0 -2" album="PQ" material="pq_hot_1_med" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1923" plane="0 -1 0 -2" album="PQ" material="pq_hot_1_med" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1924" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_light" texgens="1 0 0 128 0 -1 0 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1925" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_1_med" texgens="-1 0 0 128 0 -1 0 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="3 0 7.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 0 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="1 -0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 -0 -4" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="0 8 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="1393" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3.5 -1.25" />
                            <Vertex pos="2 3.5 -1.75" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 3.5 -1.25" />
                            <Vertex pos="-2 3.5 -1.75" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="1386" plane="1 0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1387" plane="-1 0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1388" plane="0 1 -0 -3.5" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1389" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1390" plane="-0 0.196116 0.980581 0.539319" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1391" plane="-0 -0.196116 -0.980581 -1.02961" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-3 8 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 8 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3.5 -1.25" />
                            <Vertex pos="1 3.5 -1.75" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="1 3.5 -1.25" />
                            <Vertex pos="1 3.5 -1.75" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="1 0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-0.966235 0.257663 0 0.0644156" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 0 -6" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="0 0.196116 0.980581 0.539319" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="-0 -0.196116 -0.980581 -1.02961" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="3 8 7.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 8 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 3.5 -1.25" />
                            <Vertex pos="-1 3.5 -1.75" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 3.5 -1.25" />
                            <Vertex pos="-1 3.5 -1.75" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="0.966235 0.257663 0 0.0644157" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 0 -6" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="0 0.196116 0.980581 0.539319" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="-0 -0.196116 -0.980581 -1.02961" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-3 0 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 0 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="384" plane="1 -0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -1" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="386" plane="0 1 -0 -4" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="387" plane="0 -1 0 -4" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="388" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="389" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 64 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="0 -3 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="847" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="840" plane="1 -0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 1 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="841" plane="-1 0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="842" plane="0 1 -0 -1" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="843" plane="0 -1 0 -1" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="844" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 -1 0 -64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="845" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 -1 0 -64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="0 3 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 3 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="847" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="840" plane="1 -0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 1 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="841" plane="-1 0 0 -2" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 64 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="842" plane="0 1 -0 -1" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="843" plane="0 -1 0 -1" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="844" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 128 0 -1 0 -64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="845" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 128 0 -1 0 -64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-4.25 0 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 0 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -32 0.25" />
                            <Vertex pos="0.25 -32 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -32 0.25" />
                            <Vertex pos="-0.25 -32 -0.25" />
                        </Vertices>
                        <Face id="432" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="433" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="434" plane="0 1 -0 -4" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="435" plane="0 -1 0 -32" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="436" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="437" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="4.25 0 7.75" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 0 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -32 0.25" />
                            <Vertex pos="0.25 -32 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -32 0.25" />
                            <Vertex pos="-0.25 -32 -0.25" />
                        </Vertices>
                        <Face id="432" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="433" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="434" plane="0 1 -0 -4" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="435" plane="0 -1 0 -32" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="436" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="437" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-4.25 8 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 8 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 3.5 -1.25" />
                            <Vertex pos="2.25 3.5 -1.75" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="1.75 3.5 -1.25" />
                            <Vertex pos="1.75 3.5 -1.75" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="432" plane="0.966235 -0.257663 0 -1.27221" album="PQ" material="pq_wood_2" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="433" plane="-0.966235 0.257663 0 0.789092" album="PQ" material="pq_wood_2" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="434" plane="0 1 -0 -3.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="435" plane="0 -1 0 -4" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="436" plane="-0 0.196116 0.980581 0.539319" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="437" plane="-0 -0.196116 -0.980581 -1.02961" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="4.25 8 7.75" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 8 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 3.5 -1.25" />
                            <Vertex pos="-1.75 3.5 -1.75" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-2.25 3.5 -1.25" />
                            <Vertex pos="-2.25 3.5 -1.75" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="432" plane="0.966235 0.257663 0 0.789092" album="PQ" material="pq_wood_2" texgens="0 1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="433" plane="-0.966235 -0.257663 0 -1.27221" album="PQ" material="pq_wood_2" texgens="0 -1 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="434" plane="0 1 -0 -3.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="435" plane="0 -1 0 -4" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="436" plane="-0 0.196116 0.980581 0.539319" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="437" plane="-0 -0.196116 -0.980581 -1.02961" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="0 14.25 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 14.25 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="655" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 -2.25 -1.25" />
                            <Vertex pos="2.5 -2.25 -1.75" />
                            <Vertex pos="2.5 -2.75 -1.25" />
                            <Vertex pos="2.5 -2.75 -1.75" />
                            <Vertex pos="-2.5 -2.25 -1.25" />
                            <Vertex pos="-2.5 -2.25 -1.75" />
                            <Vertex pos="-2.5 -2.75 -1.25" />
                            <Vertex pos="-2.5 -2.75 -1.75" />
                        </Vertices>
                        <Face id="648" plane="1 -0 0 -2.5" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="649" plane="-1 0 0 -2.5" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="650" plane="0 1 -0 2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="651" plane="0 -1 0 -2.75" album="PQ" material="pq_wood_2" texgens="1 0 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="652" plane="-0 0 1 1.25" album="PQ" material="pq_wood_2" texgens="1 0 0 160 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="653" plane="0 0 -1 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 160 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-2.25 11.75 3" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 11.75 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="565" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 -0.25 -3" />
                        </Vertices>
                        <Face id="558" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="559" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="560" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="561" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="562" plane="-0 0 1 -3" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="563" plane="0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="2.25 11.75 3" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 11.75 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="565" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 -0.25 -3" />
                        </Vertices>
                        <Face id="558" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="559" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="560" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="561" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="562" plane="-0 0 1 -3" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="563" plane="0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="1.75 13.75 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 1.75 0 1 0 13.75 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="787" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.75" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.75" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.75" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.75" />
                        </Vertices>
                        <Face id="780" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="781" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="782" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="783" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="784" plane="-0 0 1 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="785" plane="0 0 -1 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-1.75 13.75 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 -1.75 0 1 0 13.75 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="787" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.75" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.75" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.75" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.75" />
                        </Vertices>
                        <Face id="780" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="781" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="782" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="783" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="784" plane="-0 0 1 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="785" plane="0 0 -1 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-1.75 16.5 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.75 0 1 0 16.5 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="931" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.25" />
                            <Vertex pos="0.25 1.5 -0.25" />
                            <Vertex pos="0.25 -2.5 0.25" />
                            <Vertex pos="0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="924" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="925" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="926" plane="0 1 -0 -1.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="927" plane="0 -1 0 -2.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="928" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -160 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="929" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -160 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="1.75 16.5 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 1.75 0 1 0 16.5 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="931" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.25" />
                            <Vertex pos="0.25 1.5 -0.25" />
                            <Vertex pos="0.25 -2.5 0.25" />
                            <Vertex pos="0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="924" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="925" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="926" plane="0 1 -0 -1.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="927" plane="0 -1 0 -2.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="928" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -160 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="929" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -160 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="1.75 17.75 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 1.75 0 1 0 17.75 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="787" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.75" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.75" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.75" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.75" />
                        </Vertices>
                        <Face id="780" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="781" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="782" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="783" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="784" plane="-0 0 1 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="785" plane="0 0 -1 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-1.75 17.75 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.75 0 1 0 17.75 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="787" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.75" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.75" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.75" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.75" />
                        </Vertices>
                        <Face id="780" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="781" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="782" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="783" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="784" plane="-0 0 1 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="785" plane="0 0 -1 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="0 18 0.25" rot="-1 0 0 0.610865" scale="" transform="1 0 0 0 0 0.819152 -0.573576 18 0 0.573576 0.819152 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1251" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="1244" plane="1 -0 0 -2" album="PQ" material="pq_friction_bouncy" texgens="0 1 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1245" plane="-1 0 0 -2" album="PQ" material="pq_friction_bouncy" texgens="0 -1 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1246" plane="0 1 -0 -2" album="PQ" material="pq_friction_bouncy" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1247" plane="0 -1 0 -2" album="PQ" material="pq_friction_bouncy" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1248" plane="-0 0 1 -0.25" album="PQ" material="pq_friction_bouncy" texgens="1 0 0 128 0 -1 0 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1249" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 0 0 -1 0 -952.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="2.25 18 0.25" rot="-1 0 -0 0.610865" scale="" transform="1 0 0 2.25 0 0.819152 -0.573576 18 0 0.573576 0.819152 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="757" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2.5 0.25" />
                            <Vertex pos="-0.25 2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="750" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="751" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="752" plane="0.707107 0.707107 -0 -1.59099" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="753" plane="0.707107 -0.707107 0 -1.59099" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="754" plane="0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -160 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="755" plane="-0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -144 0 -1 0 -952.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-2.25 18 0.25" rot="-1 0 -0 0.610865" scale="" transform="1 0 0 -2.25 0 0.819152 -0.573576 18 0 0.573576 0.819152 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="757" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.25" />
                            <Vertex pos="0.25 2.5 -0.25" />
                            <Vertex pos="0.25 -2.5 0.25" />
                            <Vertex pos="0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="750" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="751" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 160 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="752" plane="-0.707107 0.707107 0 -1.59099" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="753" plane="-0.707107 -0.707107 -0 -1.59099" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="754" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -160 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="755" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 144 0 -1 0 -952.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="0 19.8431 1.54055" rot="-1 0 -0 0.610865" scale="" transform="1 0 0 0 0 0.819152 -0.573576 19.8431 0 0.573576 0.819152 1.54055 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="456" plane="1 -0 0 -2" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="457" plane="-1 0 0 -2" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="458" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="459" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="460" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 128 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="461" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 0 0 -1 0 -1096.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="0 16.1569 -1.04055" rot="-1 0 -0 0.610865" scale="" transform="1 0 0 0 0 0.819152 -0.573576 16.1569 0 0.573576 0.819152 -1.04055 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="456" plane="1 -0 0 -2" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="457" plane="-1 0 0 -2" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="458" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="459" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 128 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="460" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 128 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="461" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 0 0 -1 0 -808.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="0 -18 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -18 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="3121" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 14 0.25" />
                            <Vertex pos="4 14 -0.25" />
                            <Vertex pos="4 -14 0.25" />
                            <Vertex pos="4 -14 -0.25" />
                            <Vertex pos="-4 14 0.25" />
                            <Vertex pos="-4 14 -0.25" />
                            <Vertex pos="-4 -14 0.25" />
                            <Vertex pos="-4 -14 -0.25" />
                        </Vertices>
                        <Face id="3114" plane="1 -0 0 -4" album="PQ" material="pq_hot_2_med" texgens="0 1 0 896 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="3115" plane="-1 0 0 -4" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 896 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="3116" plane="0 1 -0 -14" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3117" plane="0 -1 0 -14" album="PQ" material="pq_hot_2_med" texgens="1 0 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3118" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 0 0 -1 0 1152 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3119" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 0 0 -0.997576 0.0695904 591.862 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="60.9362 -33.1908 7.75" rot="1 0 0 0" scale="" transform="1 0 0 60.9362 0 1 0 -33.1908 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.06379 1.6908 0.25" />
                            <Vertex pos="3.89769 -1.6908 0.25" />
                            <Vertex pos="-3.9362 1.6908 0.25" />
                            <Vertex pos="-4.06379 -0.906658 0.25" />
                            <Vertex pos="4.06379 1.6908 -0.25" />
                            <Vertex pos="3.89769 -1.6908 -0.25" />
                            <Vertex pos="-3.9362 1.6908 -0.25" />
                            <Vertex pos="-4.06379 -0.906658 -0.25" />
                        </Vertices>
                        <Face id="582" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3899.92 0 -1 0 2124.21 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1949.96 0 -0.997576 0.0695904 1076.79 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.998796 -0.0490596 0 -3.97595" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.0490597 -0.998796 0 120.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0 1 -0 -1.6908" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 1 0 0 1947.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.0980177 -0.995185 -0 -1.30062" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 1 0 0 1947.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.998796 0.0490619 0 -4.01441" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.0490657 -0.998796 0 95.7202 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="60.6624 -36.164 7.75" rot="1 0 0 0" scale="" transform="1 0 0 60.6624 0 1 0 -36.164 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.17155 1.28245 0.25" />
                            <Vertex pos="3.67475 -2.06659 0.25" />
                            <Vertex pos="-3.78995 2.06659 0.25" />
                            <Vertex pos="-4.17155 -0.505859 0.25" />
                            <Vertex pos="4.17155 1.28245 -0.25" />
                            <Vertex pos="3.67475 -2.06659 -0.25" />
                            <Vertex pos="-3.78995 2.06659 -0.25" />
                            <Vertex pos="-4.17155 -0.505859 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3882.39 0 -1 0 2314.5 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1941.2 0 -0.997576 0.0695904 1171.7 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.989176 -0.146735 0 -3.93822" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.146735 -0.989176 0 120.364 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.0980172 0.995185 -0 -1.68516" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.995185 -0.098017 0 1950.35 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.195091 -0.980785 -0 -1.30997" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.995185 -0.098017 0 1950.35 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.989176 0.146735 0 -4.05217" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.146735 -0.989176 0 95.238 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="60.098 -39.0924 7.75" rot="1 0 0 0" scale="" transform="1 0 0 60.098 0 1 0 -39.0924 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.23911 0.861717 0.25" />
                            <Vertex pos="3.4164 -2.42245 0.25" />
                            <Vertex pos="-3.6072 2.42245 0.25" />
                            <Vertex pos="-4.23911 -0.100178 0.25" />
                            <Vertex pos="4.23911 0.861717 -0.25" />
                            <Vertex pos="3.4164 -2.42245 -0.25" />
                            <Vertex pos="-3.6072 2.42245 -0.25" />
                            <Vertex pos="-4.23911 -0.100178 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3846.27 0 -1 0 2501.91 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1923.14 0 -0.997576 0.0695904 1265.18 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.970026 -0.242999 0 -3.90265" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.242997 -0.970027 0 119.423 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.195091 0.980785 -0 -1.67217" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.980785 -0.195091 0 1952.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.290285 -0.95694 -0 -1.32641" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.980785 -0.195091 0 1952.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.970029 0.242989 0 -4.08772" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.242986 -0.97003 0 94.2939 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="59.2486 -41.9476 7.75" rot="1 0 0 0" scale="" transform="1 0 0 59.2486 0 1 0 -41.9476 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.2658 0.43277 0.25" />
                            <Vertex pos="3.1252 -2.75504 0.25" />
                            <Vertex pos="-3.38969 2.75504 0.25" />
                            <Vertex pos="-4.2658 0.306431 0.25" />
                            <Vertex pos="4.2658 0.43277 -0.25" />
                            <Vertex pos="3.1252 -2.75504 -0.25" />
                            <Vertex pos="-3.38969 2.75504 -0.25" />
                            <Vertex pos="-4.2658 0.306431 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3791.91 0 -1 0 2684.64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1895.96 0 -0.997576 0.0695904 1356.33 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.941546 -0.336886 0 -3.87065" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.336887 -0.941545 0 118.052 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.290285 0.95694 -0 -1.65243" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.95694 -0.290284 0 1954.78 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.382685 -0.923879 -0 -1.34935" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.95694 -0.290284 0 1954.78 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.941546 0.336884 0 -4.11968" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.336887 -0.941545 0 92.9304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="58.1224 -44.7022 7.75" rot="1 0 0 0" scale="" transform="1 0 0 58.1224 0 1 0 -44.7022 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25146 -0.000434875 0.25" />
                            <Vertex pos="2.80396 -3.06104 0.25" />
                            <Vertex pos="-3.13956 3.06104 0.25" />
                            <Vertex pos="-4.25145 0.710159 0.25" />
                            <Vertex pos="4.25146 -0.000434875 -0.25" />
                            <Vertex pos="2.80396 -3.06104 -0.25" />
                            <Vertex pos="-3.13956 3.06104 -0.25" />
                            <Vertex pos="-4.25145 0.710159 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3719.83 0 -1 0 2860.94 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1859.92 0 -0.997576 0.0695904 1444.26 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.903996 -0.427541 0 -3.84349" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.427541 -0.903996 0 116.306 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.382685 0.923879 -0 -1.62657" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.923879 -0.382684 0 1956.61 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.471397 -0.881921 -0 -1.37782" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.923879 -0.382684 0 1956.61 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.903988 0.427557 0 -4.14689" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.427557 -0.903988 0 91.1894 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="56.7301 -47.3296 7.75" rot="1 0 0 0" scale="" transform="1 0 0 56.7301 0 1 0 -47.3296 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.19621 -0.433598 0.25" />
                            <Vertex pos="2.4556 -3.33759 0.25" />
                            <Vertex pos="-2.85921 3.3376 0.25" />
                            <Vertex pos="-4.19621 1.10701 0.25" />
                            <Vertex pos="4.19621 -0.433598 -0.25" />
                            <Vertex pos="2.4556 -3.33759 -0.25" />
                            <Vertex pos="-2.85921 3.3376 -0.25" />
                            <Vertex pos="-4.19621 1.10701 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3630.73 0 -1 0 3029.1 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1815.36 0 -0.997576 0.0695904 1528.13 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.857726 -0.514108 0 -3.82211" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.514105 -0.857727 0 114.265 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.471397 0.881921 -0 -1.59568" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.881921 -0.471397 0 1958.07 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.55557 -0.831469 -0 -1.41085" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.881921 -0.471397 0 1958.07 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.857723 0.514113 0 -4.16831" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.514112 -0.857723 0 89.139 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="55.0852 -49.8046 7.75" rot="1 0 0 0" scale="" transform="1 0 0 55.0852 0 1 0 -49.8046 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.10046 -0.862602 0.25" />
                            <Vertex pos="2.08366 -3.582 0.25" />
                            <Vertex pos="-2.55134 3.582 0.25" />
                            <Vertex pos="-4.10046 1.49318 0.25" />
                            <Vertex pos="4.10046 -0.862602 -0.25" />
                            <Vertex pos="2.08366 -3.582 -0.25" />
                            <Vertex pos="-2.55134 3.582 -0.25" />
                            <Vertex pos="-4.10046 1.49318 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3525.46 0 -1 0 3187.49 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1762.73 0 -0.997576 0.0695904 1607.14 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.803214 -0.595691 0 -3.80739" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.59569 -0.803214 0 111.984 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.555571 0.831469 -0 -1.56087" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.831469 -0.555571 0 1959.13 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.634394 -0.77301 -0 -1.44706" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.831469 -0.555571 0 1959.13 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.803218 0.595686 0 -4.18303" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.595684 -0.803219 0 86.8696 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="53.2036 -52.1033 7.75" rot="1 0 0 0" scale="" transform="1 0 0 53.2036 0 1 0 -52.1033 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.9653 -1.28328 0.25" />
                            <Vertex pos="1.6916 -3.79188 0.25" />
                            <Vertex pos="-2.21882 3.79189 0.25" />
                            <Vertex pos="-3.9653 1.86501 0.25" />
                            <Vertex pos="3.9653 -1.28328 -0.25" />
                            <Vertex pos="1.6916 -3.79188 -0.25" />
                            <Vertex pos="-2.21882 3.79189 -0.25" />
                            <Vertex pos="-3.9653 1.86501 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3405.03 0 -1 0 3334.61 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1702.52 0 -0.997576 0.0695904 1680.52 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.740946 -0.671565 0 -3.79988" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.671564 -0.740946 0 109.575 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.634393 0.773011 -0 -1.52357" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.77301 -0.634393 0 1959.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.707106 -0.707107 -0 -1.48513" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.77301 -0.634393 0 1959.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.74094 0.671571 0 -4.19054" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.671571 -0.74094 0 84.4479 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="51.1033 -54.2036 7.75" rot="1 0 0 0" scale="" transform="1 0 0 51.1033 0 1 0 -54.2036 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.79189 -1.6916 0.25" />
                            <Vertex pos="1.28329 -3.9653 0.25" />
                            <Vertex pos="-1.86501 3.9653 0.25" />
                            <Vertex pos="-3.79189 2.21883 0.25" />
                            <Vertex pos="3.79189 -1.6916 -0.25" />
                            <Vertex pos="1.28329 -3.9653 -0.25" />
                            <Vertex pos="-1.86501 3.9653 -0.25" />
                            <Vertex pos="-3.79189 2.21883 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3270.61 0 -1 0 3469.03 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1635.31 0 -0.997576 0.0695904 1747.57 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.671565 -0.740946 0 -3.79988" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.740946 -0.671564 0 107.108 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.707107 0.707107 -0 -1.48513" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.707107 -0.707107 0 1959.85 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.773011 -0.634393 -0 -1.52356" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.707107 -0.707107 0 1959.85 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.671569 0.740942 0 -4.19054" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.74094 -0.671571 0 81.9916 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="48.8046 -56.0852 7.75" rot="1 0 0 0" scale="" transform="1 0 0 48.8046 0 1 0 -56.0852 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.582 -2.08366 0.25" />
                            <Vertex pos="0.862602 -4.10046 0.25" />
                            <Vertex pos="-1.49318 4.10046 0.25" />
                            <Vertex pos="-3.582 2.55135 0.25" />
                            <Vertex pos="3.582 -2.08366 -0.25" />
                            <Vertex pos="0.862602 -4.10046 -0.25" />
                            <Vertex pos="-1.49318 4.10046 -0.25" />
                            <Vertex pos="-3.582 2.55135 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3123.49 0 -1 0 3589.46 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1561.75 0 -0.997576 0.0695904 1807.63 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.595691 -0.803214 0 -3.80739" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.803213 -0.595692 0 104.697 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.77301 0.634394 -0 -1.44706" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.634393 -0.77301 0 1959.49 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.831469 -0.555571 -0 -1.56087" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.634393 -0.77301 0 1959.49 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.595683 0.803219 0 -4.18303" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.803219 -0.595684 0 79.5649 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="46.3297 -57.7301 7.75" rot="1 0 0 0" scale="" transform="1 0 0 46.3297 0 1 0 -57.7301 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.33754 -2.45565 0.25" />
                            <Vertex pos="0.433636 -4.19615 0.25" />
                            <Vertex pos="-1.10706 4.19615 0.25" />
                            <Vertex pos="-3.33754 2.85916 0.25" />
                            <Vertex pos="3.33754 -2.45565 -0.25" />
                            <Vertex pos="0.433636 -4.19615 -0.25" />
                            <Vertex pos="-1.10706 4.19615 -0.25" />
                            <Vertex pos="-3.33754 2.85916 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 2965.1 0 -1 0 3694.72 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1482.55 0 -0.997576 0.0695904 1860.14 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.514096 -0.857733 0 -3.82211" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.857732 -0.514097 0 102.417 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.831469 0.555571 -0 -1.41077" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.555571 -0.831469 0 1958.65 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.88192 -0.4714 -0 -1.59563" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.555571 -0.831469 0 1958.65 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.514129 0.857713 0 -4.16826" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.857714 -0.514128 0 77.3002 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="43.7022 -59.1224 7.75" rot="1 0 0 0" scale="" transform="1 0 0 43.7022 0 1 0 -59.1224 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.06114 -2.80381 0.25" />
                            <Vertex pos="0.000335693 -4.2515 0.25" />
                            <Vertex pos="-0.710045 4.2515 0.25" />
                            <Vertex pos="-3.06114 3.1396 0.25" />
                            <Vertex pos="3.06114 -2.80381 -0.25" />
                            <Vertex pos="0.000335693 -4.2515 -0.25" />
                            <Vertex pos="-0.710045 4.2515 -0.25" />
                            <Vertex pos="-3.06114 3.1396 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 2796.94 0 -1 0 3783.83 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1398.47 0 -0.997576 0.0695904 1904.59 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.427564 -0.903985 0 -3.84344" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.903984 -0.427566 0 100.378 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.881919 0.471401 -0 -1.37796" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.4714 -0.881919 0 1957.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.92388 -0.382682 -0 -1.62666" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.4714 -0.881919 0 1957.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.427528 0.904002 0 -4.14693" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.904002 -0.427527 0 75.2466 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="40.9476 -60.2486 7.75" rot="1 0 0 0" scale="" transform="1 0 0 40.9476 0 1 0 -60.2486 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75495 -3.12531 0.25" />
                            <Vertex pos="-0.432652 -4.2658 0.25" />
                            <Vertex pos="-0.30653 4.2658 0.25" />
                            <Vertex pos="-2.75495 3.38971 0.25" />
                            <Vertex pos="2.75495 -3.12531 -0.25" />
                            <Vertex pos="-0.432652 -4.2658 -0.25" />
                            <Vertex pos="-0.30653 4.2658 -0.25" />
                            <Vertex pos="-2.75495 3.38971 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 2620.64 0 -1 0 3855.91 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1310.32 0 -0.997576 0.0695904 1940.54 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.336876 -0.941549 0 -3.87071" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.941548 -0.336878 0 98.6281 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.92388 0.382682 -0 -1.34925" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.382681 -0.923881 0 1955.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.95694 -0.290287 -0 -1.65233" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.382681 -0.923881 0 1955.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.336901 0.94154 0 -4.11969" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.941538 -0.336906 0 73.5063 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="38.0924 -61.098 7.75" rot="1 0 0 0" scale="" transform="1 0 0 38.0924 0 1 0 -61.098 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.42255 -3.4164 0.25" />
                            <Vertex pos="-0.861847 -4.2391 0.25" />
                            <Vertex pos="0.100254 4.23909 0.25" />
                            <Vertex pos="-2.42254 3.60719 0.25" />
                            <Vertex pos="2.42255 -3.4164 -0.25" />
                            <Vertex pos="-0.861847 -4.2391 -0.25" />
                            <Vertex pos="0.100254 4.23909 -0.25" />
                            <Vertex pos="-2.42254 3.60719 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 2437.91 0 -1 0 3910.27 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1218.96 0 -0.997576 0.0695904 1967.65 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.242981 -0.970031 0 -3.90265" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.970031 -0.242981 0 97.2684 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.956939 0.290288 -0 -1.32649" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.290287 -0.95694 0 1953.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.980786 -0.195087 -0 -1.67228" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.290287 -0.95694 0 1953.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.24297 0.970034 0 -4.0877" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.970033 -0.242972 0 72.1413 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="35.164 -61.6624 7.75" rot="1 0 0 0" scale="" transform="1 0 0 35.164 0 1 0 -61.6624 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.06651 -3.67474 0.25" />
                            <Vertex pos="-1.28236 -4.17154 0.25" />
                            <Vertex pos="0.505814 4.17154 0.25" />
                            <Vertex pos="-2.06651 3.78994 0.25" />
                            <Vertex pos="2.06651 -3.67474 -0.25" />
                            <Vertex pos="-1.28236 -4.17154 -0.25" />
                            <Vertex pos="0.505814 4.17154 -0.25" />
                            <Vertex pos="-2.06651 3.78994 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 2250.5 0 -1 0 3946.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1125.25 0 -0.997576 0.0695904 1985.67 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.146743 -0.989175 0 -3.9382" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.989175 -0.146742 0 96.3134 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.980786 0.195087 -0 -1.30991" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.195087 -0.980786 0 1951.53 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.995185 -0.0980187 -0 -1.68507" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.195087 -0.980786 0 1951.53 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.146742 0.989175 0 -4.05216" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.989175 -0.146742 0 71.1985 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="32.1908 -61.9362 7.75" rot="1 0 0 0" scale="" transform="1 0 0 32.1908 0 1 0 -61.9362 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.69088 -3.89771 0.25" />
                            <Vertex pos="-1.69089 -4.06381 0.25" />
                            <Vertex pos="0.906731 4.06381 0.25" />
                            <Vertex pos="-1.69086 3.93621 0.25" />
                            <Vertex pos="1.69088 -3.89771 -0.25" />
                            <Vertex pos="-1.69089 -4.06381 -0.25" />
                            <Vertex pos="0.906731 4.06381 -0.25" />
                            <Vertex pos="-1.69086 3.93621 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 2060.21 0 -1 0 3963.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1030.11 0 -0.997576 0.0695904 1994.41 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="0.0490571 -0.998796 0 -3.97597" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.998796 -0.0490571 0 95.8485 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.995185 0.0980181 -0 -1.30069" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.0980185 -0.995185 0 1949.14 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-1 3.74018e-006 0 -1.69087" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.0980185 -0.995185 0 1949.14 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="-0.0490633 0.998796 0 -4.01443" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.998796 -0.0490632 0 70.7213 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="28.8092 -61.9362 7.75" rot="1 0 0 0" scale="" transform="1 0 0 28.8092 0 1 0 -61.9362 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.6907 -4.0638 0.25" />
                            <Vertex pos="-1.69073 -3.8977 0.25" />
                            <Vertex pos="1.69073 3.9362 0.25" />
                            <Vertex pos="-0.906599 4.06379 0.25" />
                            <Vertex pos="1.6907 -4.0638 -0.25" />
                            <Vertex pos="-1.69073 -3.8977 -0.25" />
                            <Vertex pos="1.69073 3.9362 -0.25" />
                            <Vertex pos="-0.906599 4.06379 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 1843.79 0 -1 0 3963.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -921.894 0 -0.997576 0.0695904 1994.41 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.049062 -0.998796 -0 -3.97596" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.998796 0.0490621 0 120.835 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="1 -3.74019e-006 0 -1.69072" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0 -1 0 1947.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.995185 0.0980162 0 -1.30055" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0 -1 0 1947.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.0490644 0.998796 -0 -4.01441" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.998796 0.0490682 0 95.715 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="25.8359 -61.6624 7.75" rot="1 0 0 0" scale="" transform="1 0 0 25.8359 0 1 0 -61.6624 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.28254 -4.17155 0.25" />
                            <Vertex pos="-2.06667 -3.67475 0.25" />
                            <Vertex pos="2.06667 3.78995 0.25" />
                            <Vertex pos="-0.505909 4.17155 0.25" />
                            <Vertex pos="1.28254 -4.17155 -0.25" />
                            <Vertex pos="-2.06667 -3.67475 -0.25" />
                            <Vertex pos="2.06667 3.78995 -0.25" />
                            <Vertex pos="-0.505909 4.17155 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 1653.5 0 -1 0 3946.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -826.749 0 -0.997576 0.0695904 1985.67 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.146728 -0.989177 -0 -3.93822" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.989177 0.146728 0 120.367 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.995185 -0.098016 0 -1.68524" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.0980159 -0.995185 0 1950.35 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.980784 0.195095 0 -1.31003" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.0980159 -0.995185 0 1950.35 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.146728 0.989177 -0 -4.05217" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.989177 0.146728 0 95.2455 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="22.9076 -61.098 7.75" rot="1 0 0 0" scale="" transform="1 0 0 22.9076 0 1 0 -61.098 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.861643 -4.2391 0.25" />
                            <Vertex pos="-2.4224 -3.4165 0.25" />
                            <Vertex pos="2.4224 3.6072 0.25" />
                            <Vertex pos="-0.100109 4.2391 0.25" />
                            <Vertex pos="0.861643 -4.2391 -0.25" />
                            <Vertex pos="-2.4224 -3.4165 -0.25" />
                            <Vertex pos="2.4224 3.6072 -0.25" />
                            <Vertex pos="-0.100109 4.2391 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 1466.09 0 -1 0 3910.27 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -733.043 0 -0.997576 0.0695904 1967.65 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.242977 -0.970032 -0 -3.9027" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.970032 0.242978 0 119.413 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.980785 -0.195094 0 -1.67211" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.195094 -0.980784 0 1952.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.956941 0.290284 0 -1.32634" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.195094 -0.980784 0 1952.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.242996 0.970027 -0 -4.08772" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.970028 0.242995 0 94.2889 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="20.0524 -60.2487 7.75" rot="1 0 0 0" scale="" transform="1 0 0 20.0524 0 1 0 -60.2487 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.432802 -4.26585 0.25" />
                            <Vertex pos="-2.75509 -3.12515 0.25" />
                            <Vertex pos="2.75509 3.38974 0.25" />
                            <Vertex pos="0.306398 4.26585 0.25" />
                            <Vertex pos="0.432802 -4.26585 -0.25" />
                            <Vertex pos="-2.75509 -3.12515 -0.25" />
                            <Vertex pos="2.75509 3.38974 -0.25" />
                            <Vertex pos="0.306398 4.26585 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 1283.35 0 -1 0 3855.91 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -641.677 0 -0.997576 0.0695904 1940.54 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.336904 -0.941539 -0 -3.87065" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.941539 0.336903 0 118.059 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.956941 -0.290284 0 -1.65247" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.290284 -0.956941 0 1954.79 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.923878 0.382687 0 -1.34941" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.290284 -0.956941 0 1954.79 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.336874 0.94155 -0 -4.11973" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.94155 0.336874 0 92.9355 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="17.2978 -59.1224 7.75" rot="1 0 0 0" scale="" transform="1 0 0 17.2978 0 1 0 -59.1224 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.000486374 -4.25146 0.25" />
                            <Vertex pos="-3.061 -2.80395 0.25" />
                            <Vertex pos="3.061 3.13955 0.25" />
                            <Vertex pos="0.710194 4.25146 0.25" />
                            <Vertex pos="-0.000486374 -4.25146 -0.25" />
                            <Vertex pos="-3.061 -2.80395 -0.25" />
                            <Vertex pos="3.061 3.13955 -0.25" />
                            <Vertex pos="0.710194 4.25146 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 1107.06 0 -1 0 3783.83 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -553.53 0 -0.997576 0.0695904 1904.59 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.427554 -0.90399 -0 -3.84348" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.90399 0.427553 0 116.305 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.923878 -0.382687 0 -1.62653" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.382687 -0.923878 0 1956.61 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.881921 0.471397 0 -1.37779" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.382687 -0.923878 0 1956.61 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.427574 0.90398 -0 -4.1469" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.903981 0.427573 0 91.1807 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="14.6703 -57.7301 7.75" rot="1 0 0 0" scale="" transform="1 0 0 14.6703 0 1 0 -57.7301 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.433543 -4.1962 0.25" />
                            <Vertex pos="-3.33764 -2.4555 0.25" />
                            <Vertex pos="3.33764 2.85919 0.25" />
                            <Vertex pos="1.10693 4.1962 0.25" />
                            <Vertex pos="-0.433543 -4.1962 -0.25" />
                            <Vertex pos="-3.33764 -2.4555 -0.25" />
                            <Vertex pos="3.33764 2.85919 -0.25" />
                            <Vertex pos="1.10693 4.1962 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 938.902 0 -1 0 3694.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -469.45 0 -0.997576 0.0695904 1860.14 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.514114 -0.857722 -0 -3.82206" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.857722 0.514114 0 114.27 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.881921 -0.471397 0 -1.59572" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.471397 -0.881921 0 1958.08 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.831467 0.555574 0 -1.41092" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.471397 -0.881921 0 1958.08 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.514095 0.857733 -0 -4.16829" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.857734 0.514094 0 89.1472 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="12.1953 -56.0852 7.75" rot="1 0 0 0" scale="" transform="1 0 0 12.1953 0 1 0 -56.0852 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.862638 -4.10041 0.25" />
                            <Vertex pos="-3.58194 -2.08371 0.25" />
                            <Vertex pos="3.58194 2.55131 0.25" />
                            <Vertex pos="1.49323 4.10041 0.25" />
                            <Vertex pos="-0.862638 -4.10041 -0.25" />
                            <Vertex pos="-3.58194 -2.08371 -0.25" />
                            <Vertex pos="3.58194 2.55131 -0.25" />
                            <Vertex pos="1.49323 4.10041 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 780.501 0 -1 0 3589.45 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -390.25 0 -0.997576 0.0695904 1807.63 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.595686 -0.803218 -0 -3.80738" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.803217 0.595686 0 111.979 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.831467 -0.555574 0 -1.56083" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.555574 -0.831467 0 1959.13 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.773011 0.634393 0 -1.44699" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.555574 -0.831467 0 1959.13 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.595701 0.803206 -0 -4.18299" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.803205 0.595703 0 86.8633 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="9.89674 -54.2036 7.75" rot="1 0 0 0" scale="" transform="1 0 0 9.89674 0 1 0 -54.2036 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.28334 -3.96526 0.25" />
                            <Vertex pos="-3.79184 -1.69167 0.25" />
                            <Vertex pos="3.79184 2.21886 0.25" />
                            <Vertex pos="1.86504 3.96526 0.25" />
                            <Vertex pos="-1.28334 -3.96526 -0.25" />
                            <Vertex pos="-3.79184 -1.69167 -0.25" />
                            <Vertex pos="3.79184 2.21886 -0.25" />
                            <Vertex pos="1.86504 3.96526 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 633.391 0 -1 0 3469.03 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -316.696 0 -0.997576 0.0695904 1747.57 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.671562 -0.740948 -0 -3.7999" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.740947 0.671563 0 109.571 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.77301 -0.634394 0 -1.5235" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.634393 -0.77301 0 1959.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.70711 0.707104 0 -1.48506" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.634393 -0.77301 0 1959.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.67157 0.740942 -0 -4.19053" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.740942 0.67157 0 84.4446 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="7.79644 -52.1033 7.75" rot="1 0 0 0" scale="" transform="1 0 0 7.79644 0 1 0 -52.1033 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.69154 -3.79196 0.25" />
                            <Vertex pos="-3.96534 -1.28316 0.25" />
                            <Vertex pos="3.96534 1.86497 0.25" />
                            <Vertex pos="2.21874 3.79196 0.25" />
                            <Vertex pos="-1.69154 -3.79196 -0.25" />
                            <Vertex pos="-3.96534 -1.28316 -0.25" />
                            <Vertex pos="3.96534 1.86497 -0.25" />
                            <Vertex pos="2.21874 3.79196 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 498.972 0 -1 0 3334.61 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -249.486 0 -0.997576 0.0695904 1680.52 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.740958 -0.671552 -0 -3.79986" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.671552 0.740957 0 107.118 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.70711 -0.707104 0 -1.4852" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.707104 -0.70711 0 1959.85 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.634392 0.773012 0 -1.52368" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.707104 -0.70711 0 1959.85 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.740936 0.671575 -0 -4.19053" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.671573 0.740938 0 81.9979 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="5.91479 -49.8046 7.75" rot="1 0 0 0" scale="" transform="1 0 0 5.91479 0 1 0 -49.8046 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.08369 -3.58189 0.25" />
                            <Vertex pos="-4.10039 -0.862682 0.25" />
                            <Vertex pos="4.10039 1.49322 0.25" />
                            <Vertex pos="2.55132 3.5819 0.25" />
                            <Vertex pos="-2.08369 -3.58189 -0.25" />
                            <Vertex pos="-4.10039 -0.862682 -0.25" />
                            <Vertex pos="4.10039 1.49322 -0.25" />
                            <Vertex pos="2.55132 3.5819 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 378.547 0 -1 0 3187.5 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -189.273 0 -0.997576 0.0695904 1607.14 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.803208 -0.595699 -0 -3.80736" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.595699 0.803208 0 104.687 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.634391 -0.773013 0 -1.44697" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.773012 -0.634392 0 1959.49 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.555575 0.831467 0 -1.56078" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.773012 -0.634392 0 1959.49 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.803208 0.595699 -0 -4.18297" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.595703 0.803205 0 79.5688 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="4.26991 -47.3297 7.75" rot="1 0 0 0" scale="" transform="1 0 0 4.26991 0 1 0 -47.3297 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.4555 -3.33764 0.25" />
                            <Vertex pos="-4.1962 -0.433544 0.25" />
                            <Vertex pos="4.1962 1.10693 0.25" />
                            <Vertex pos="2.8592 3.33764 0.25" />
                            <Vertex pos="-2.4555 -3.33764 -0.25" />
                            <Vertex pos="-4.1962 -0.433544 -0.25" />
                            <Vertex pos="4.1962 1.10693 -0.25" />
                            <Vertex pos="2.8592 3.33764 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 273.274 0 -1 0 3029.1 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -136.637 0 -0.997576 0.0695904 1528.14 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.857722 -0.514114 -0 -3.82206" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.514114 0.857722 0 102.423 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.555574 -0.831467 0 -1.41092" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.831467 -0.555574 0 1958.66 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.471396 0.881922 0 -1.59572" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.831467 -0.555574 0 1958.66 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.857735 0.514093 -0 -4.16829" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.514094 0.857734 0 77.2969 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="2.87765 -44.7022 7.75" rot="1 0 0 0" scale="" transform="1 0 0 2.87765 0 1 0 -44.7022 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.80395 -3.06099 0.25" />
                            <Vertex pos="-4.25145 -0.000495911 0.25" />
                            <Vertex pos="4.25145 0.710205 0.25" />
                            <Vertex pos="3.13956 3.06099 0.25" />
                            <Vertex pos="-2.80395 -3.06099 -0.25" />
                            <Vertex pos="-4.25145 -0.000495911 -0.25" />
                            <Vertex pos="4.25145 0.710205 -0.25" />
                            <Vertex pos="3.13956 3.06099 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 184.17 0 -1 0 2860.94 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -92.0848 0 -0.997576 0.0695904 1444.26 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.90399 -0.427554 -0 -3.84348" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.427553 0.90399 0 100.369 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.471397 -0.881921 0 -1.37778" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.881921 -0.471397 0 1957.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.382687 0.923878 0 -1.62651" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.881921 -0.471397 0 1957.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.903982 0.427571 -0 -4.1469" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.427573 0.903981 0 75.2501 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="1.75135 -41.9476 7.75" rot="1 0 0 0" scale="" transform="1 0 0 1.75135 0 1 0 -41.9476 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.12515 -2.7551 0.25" />
                            <Vertex pos="-4.26586 0.432804 0.25" />
                            <Vertex pos="4.26586 0.306385 0.25" />
                            <Vertex pos="3.38975 2.7551 0.25" />
                            <Vertex pos="-3.12515 -2.7551 -0.25" />
                            <Vertex pos="-4.26586 0.432804 -0.25" />
                            <Vertex pos="4.26586 0.306385 -0.25" />
                            <Vertex pos="3.38975 2.7551 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 112.087 0 -1 0 2684.65 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -56.0432 0 -0.997576 0.0695904 1356.33 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.941538 -0.336906 -0 -3.87066" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.336904 0.941539 0 98.6335 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.382686 -0.923878 0 -1.34942" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.923878 -0.382687 0 1955.74 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.290284 0.956941 0 -1.65248" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.923878 -0.382687 0 1955.74 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.941551 0.336871 -0 -4.11974" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.33687 0.941551 0 73.5064 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="0.902002 -39.0924 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0.902002 0 1 0 -39.0924 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.4165 -2.42241 0.25" />
                            <Vertex pos="-4.2391 0.86166 0.25" />
                            <Vertex pos="4.2391 -0.100121 0.25" />
                            <Vertex pos="3.6072 2.42241 0.25" />
                            <Vertex pos="-3.4165 -2.42241 -0.25" />
                            <Vertex pos="-4.2391 0.86166 -0.25" />
                            <Vertex pos="4.2391 -0.100121 -0.25" />
                            <Vertex pos="3.6072 2.42241 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 57.7281 0 -1 0 2501.91 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -28.8641 0 -0.997576 0.0695904 1265.18 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.970032 -0.242976 -0 -3.9027" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.242975 0.970032 0 97.2603 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.290283 -0.956941 0 -1.32635" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.956941 -0.290284 0 1953.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.195093 0.980785 0 -1.67212" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.956941 -0.290284 0 1953.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.970028 0.242994 -0 -4.08772" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.242995 0.970028 0 72.1402 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="0.337649 -36.1641 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0.337649 0 1 0 -36.1641 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.67475 -2.06667 0.25" />
                            <Vertex pos="-4.17155 1.28254 0.25" />
                            <Vertex pos="4.17155 -0.505913 0.25" />
                            <Vertex pos="3.78995 2.06667 0.25" />
                            <Vertex pos="-3.67475 -2.06667 -0.25" />
                            <Vertex pos="-4.17155 1.28254 -0.25" />
                            <Vertex pos="4.17155 -0.505913 -0.25" />
                            <Vertex pos="3.78995 2.06667 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 21.6095 0 -1 0 2314.5 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -10.8048 0 -0.997576 0.0695904 1171.7 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.989177 -0.146728 -0 -3.93822" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.146728 0.989177 0 96.3264 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.195094 -0.980785 0 -1.31004" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.980785 -0.195093 0 1951.53 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-0.098016 0.995185 0 -1.68524" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.980785 -0.195093 0 1951.53 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.989177 0.146728 -0 -4.05217" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.146728 0.989177 0 71.2011 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="0.0637982 -33.1908 7.75" rot="1 0 0 0" scale="" transform="1 0 0 0.0637982 0 1 0 -33.1908 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="589" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.8977 -1.69072 0.25" />
                            <Vertex pos="-4.0638 1.69071 0.25" />
                            <Vertex pos="4.0638 -0.906605 0.25" />
                            <Vertex pos="3.9362 1.69073 0.25" />
                            <Vertex pos="-3.8977 -1.69072 -0.25" />
                            <Vertex pos="-4.0638 1.69071 -0.25" />
                            <Vertex pos="4.0638 -0.906605 -0.25" />
                            <Vertex pos="3.9362 1.69073 -0.25" />
                        </Vertices>
                        <Face id="582" plane="0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 4.08308 0 -1 0 2124.21 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="583" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -2.04154 0 -0.997576 0.0695904 1076.79 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="584" plane="-0.998796 -0.049062 -0 -3.97596" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.0490621 0.998796 0 95.8374 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="585" plane="0.0980141 -0.995185 0 -1.30055" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.995185 -0.098015 0 1949.14 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="586" plane="-2.5034e-006 1 0 -1.69072" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.995185 -0.098015 0 1949.14 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="587" plane="0.998795 0.0490681 -0 -4.01442" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.0490679 0.998796 0 70.7145 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="65.167 -33.2153 9.75" rot="1 0 0 0" scale="" transform="1 0 0 65.167 0 1 0 -33.2153 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2491" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.333054 1.7153 0.75" />
                            <Vertex pos="0.164551 -1.71531 0.75" />
                            <Vertex pos="-0.166946 1.7153 0.75" />
                            <Vertex pos="-0.333046 -1.6663 0.75" />
                            <Vertex pos="0.333054 1.7153 -2.25" />
                            <Vertex pos="0.164551 -1.71531 -2.25" />
                            <Vertex pos="-0.166946 1.7153 -2.25" />
                            <Vertex pos="-0.333046 -1.6663 -2.25" />
                        </Vertices>
                        <Face id="2484" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 4458.69 0 -1 0 -2130.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2485" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 21.3145 0 -1 0 -2130.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2486" plane="0.998796 -0.0490584 0 -0.248503" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.0490574 -0.998796 0 110.693 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2487" plane="0 1 -0 -1.7153" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 1 0 0 2218.69 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2488" plane="-0.0980189 -0.995185 -0 -1.69092" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 1 0 0 2218.69 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2489" plane="-0.998796 0.0490596 0 -0.250897" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.0490597 -0.998796 0 109.123 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="64.8343 -36.6049 9.75" rot="1 0 0 0" scale="" transform="1 0 0 64.8343 0 1 0 -36.6049 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2491" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.497185 1.67428 0.75" />
                            <Vertex pos="-0.00680542 -1.72329 0.75" />
                            <Vertex pos="-0.000389099 1.72329 0.75" />
                            <Vertex pos="-0.497192 -1.62575 0.75" />
                            <Vertex pos="0.497185 1.67428 -2.25" />
                            <Vertex pos="-0.00680542 -1.72329 -2.25" />
                            <Vertex pos="-0.000389099 1.72329 -2.25" />
                            <Vertex pos="-0.497192 -1.62575 -2.25" />
                        </Vertices>
                        <Face id="2484" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 4437.4 0 -1 0 -1913.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2485" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 42.6045 0 -1 0 -1913.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2486" plane="0.989176 -0.146733 0 -0.246132" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.146736 -0.989176 0 110.664 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2487" plane="0.0980234 0.995184 -0 -1.71495" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.995185 -0.098017 0 2218.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2488" plane="-0.195083 -0.980787 -0 -1.69151" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.995185 -0.098017 0 2218.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2489" plane="-0.989176 0.146736 0 -0.253254" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.146735 -0.989176 0 109.094 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="64.171 -39.9453 9.75" rot="1 0 0 0" scale="" transform="1 0 0 64.171 0 1 0 -39.9453 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2491" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.656548 1.61714 0.75" />
                            <Vertex pos="-0.178051 -1.71468 0.75" />
                            <Vertex pos="0.166153 1.71468 0.75" />
                            <Vertex pos="-0.656555 -1.56953 0.75" />
                            <Vertex pos="0.656548 1.61714 -2.25" />
                            <Vertex pos="-0.178051 -1.71468 -2.25" />
                            <Vertex pos="0.166153 1.71468 -2.25" />
                            <Vertex pos="-0.656555 -1.56953 -2.25" />
                        </Vertices>
                        <Face id="2484" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 4394.94 0 -1 0 -1699.5 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2485" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 85.0586 0 -1 0 -1699.5 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2486" plane="0.97003 -0.242986 0 -0.243929" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.242985 -0.97003 0 110.605 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2487" plane="0.195079 0.980787 -0 -1.71415" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.980785 -0.195091 0 2218.98 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2488" plane="-0.29028 -0.956942 -0 -1.69253" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.980785 -0.195091 0 2218.98 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2489" plane="-0.970027 0.242996 0 -0.255487" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.242997 -0.970027 0 109.035 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="63.1834 -43.2044 9.75" rot="1 0 0 0" scale="" transform="1 0 0 63.1834 0 1 0 -43.2044 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2491" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.809544 1.54438 0.75" />
                            <Vertex pos="-0.347553 -1.68953 0.75" />
                            <Vertex pos="0.331028 1.68953 0.75" />
                            <Vertex pos="-0.80954 -1.49817 0.75" />
                            <Vertex pos="0.809544 1.54438 -2.25" />
                            <Vertex pos="-0.347553 -1.68953 -2.25" />
                            <Vertex pos="0.331028 1.68953 -2.25" />
                            <Vertex pos="-0.80954 -1.49817 -2.25" />
                        </Vertices>
                        <Face id="2484" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 4331.74 0 -1 0 -1490.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2485" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 148.265 0 -1 0 -1490.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2486" plane="0.941545 -0.336886 0 -0.241942" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.336889 -0.941544 0 110.517 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2487" plane="0.290273 0.956944 -0 -1.71287" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.95694 -0.290286 0 2219.11 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2488" plane="-0.382681 -0.92388 -0 -1.69393" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.95694 -0.290286 0 2219.11 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2489" plane="-0.941545 0.336887 0 -0.257504" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.336887 -0.941545 0 108.949 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-2.18335 -43.2044 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.18335 0 1 0 -43.2044 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2491" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.347649 -1.68961 0.75" />
                            <Vertex pos="-0.809554 1.54449 0.75" />
                            <Vertex pos="0.809552 -1.49828 0.75" />
                            <Vertex pos="-0.331146 1.68961 0.75" />
                            <Vertex pos="0.347649 -1.68961 -2.25" />
                            <Vertex pos="-0.809552 1.54449 -2.25" />
                            <Vertex pos="0.809553 -1.49828 -2.25" />
                            <Vertex pos="-0.331146 1.68961 -2.25" />
                        </Vertices>
                        <Face id="2484" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 148.266 0 -1 0 -1490.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2485" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 4331.73 0 -1 0 -1490.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2486" plane="-0.941542 -0.336896 -6.17323e-007 -0.241896" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.336895 0.941542 0 109.309 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2487" plane="0.382689 -0.923877 0 -1.69403" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.923878 -0.382686 0 2219.17 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2488" plane="-0.290278 0.956942 0 -1.71298" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.923878 -0.382686 0 2219.17 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2489" plane="0.941539 0.336904 3.18014e-007 -0.257449" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.336904 0.941539 0 107.741 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-3.171 -39.9453 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.171 0 1 0 -39.9453 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2491" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.178104 -1.71458 0.75" />
                            <Vertex pos="-0.656495 1.61704 0.75" />
                            <Vertex pos="0.656494 -1.56947 0.75" />
                            <Vertex pos="-0.1661 1.71458 0.75" />
                            <Vertex pos="0.178105 -1.71458 -2.25" />
                            <Vertex pos="-0.656493 1.61704 -2.25" />
                            <Vertex pos="0.656492 -1.56947 -2.25" />
                            <Vertex pos="-0.166102 1.71458 -2.25" />
                        </Vertices>
                        <Face id="2484" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 85.0557 0 -1 0 -1699.5 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2485" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 4394.94 0 -1 0 -1699.5 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2486" plane="-0.970026 -0.243 -6.35999e-007 -0.243877" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.242999 0.970027 0 109.214 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2487" plane="0.290272 -0.956944 9.66003e-008 -1.69246" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.956941 -0.290283 0 2219.05 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2488" plane="-0.19508 0.980787 1.30811e-007 -1.71404" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.956941 -0.290283 0 2219.05 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2489" plane="0.970033 0.242975 -6.55276e-007 -0.255478" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.242975 0.970032 0 107.646 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-3.8343 -36.6049 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.8343 0 1 0 -36.6049 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2491" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.00679731 -1.72338 0.75" />
                            <Vertex pos="-0.4972 1.67437 0.75" />
                            <Vertex pos="0.497203 -1.62583 0.75" />
                            <Vertex pos="0.000400066 1.72338 0.75" />
                            <Vertex pos="0.00679898 -1.72338 -2.25" />
                            <Vertex pos="-0.497202 1.67437 -2.25" />
                            <Vertex pos="0.497202 -1.62583 -2.25" />
                            <Vertex pos="0.000400543 1.72338 -2.25" />
                        </Vertices>
                        <Face id="2484" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 42.6045 0 -1 0 -1913.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2485" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 4437.4 0 -1 0 -1913.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2486" plane="-0.989177 -0.146727 6.58382e-007 -0.246144" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.146728 0.989177 0 109.166 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2487" plane="0.195096 -0.980784 1.08594e-007 -1.69159" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.980785 -0.195093 0 2218.91 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2488" plane="-0.0980183 0.995185 -1.55853e-008 -1.71504" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.980785 -0.195093 0 2218.91 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2489" plane="0.989177 0.146728 -3.24277e-007 -0.253266" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.146728 0.989177 0 107.596 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-4.16695 -33.2153 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.16695 0 1 0 -33.2153 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2491" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.16455 -1.71522 0.75" />
                            <Vertex pos="-0.333049 1.71522 0.75" />
                            <Vertex pos="0.333051 -1.66621 0.75" />
                            <Vertex pos="0.166951 1.71522 0.75" />
                            <Vertex pos="-0.16455 -1.71522 -2.25" />
                            <Vertex pos="-0.333049 1.71522 -2.25" />
                            <Vertex pos="0.333049 -1.66621 -2.25" />
                            <Vertex pos="0.16695 1.71522 -2.25" />
                        </Vertices>
                        <Face id="2484" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 21.3152 0 -1 0 -2130.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2485" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 4458.68 0 -1 0 -2130.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2486" plane="-0.998796 -0.0490596 -0 -0.2485" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.0490599 0.998796 0 109.125 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2487" plane="0.0980185 -0.995185 0 -1.69083" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.995185 -0.0980148 0 2218.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2488" plane="0 1 0 -1.71522" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.995185 -0.0980148 0 2218.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2489" plane="0.998796 0.0490618 -6.64784e-007 -0.250902" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.0490621 0.998796 0 107.555 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="61.8811 -46.3507 9.75" rot="1 0 0 0" scale="" transform="1 0 0 61.8811 0 1 0 -46.3507 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2479" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.95475 1.45683 0.75" />
                            <Vertex pos="-0.513847 -1.64817 0.75" />
                            <Vertex pos="0.492779 1.64818 0.75" />
                            <Vertex pos="-0.954754 -1.41251 0.75" />
                            <Vertex pos="0.95475 1.45683 -2.25" />
                            <Vertex pos="-0.513847 -1.64817 -2.25" />
                            <Vertex pos="0.492779 1.64818 -2.25" />
                            <Vertex pos="-0.954754 -1.41251 -2.25" />
                        </Vertices>
                        <Face id="2472" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 4248.39 0 -1 0 -1289.55 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2473" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 231.613 0 -1 0 -1289.55 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2474" plane="0.903985 -0.427565 0 -0.24019" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.427566 -0.903984 0 110.411 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2475" plane="0.382675 0.923883 -0 -1.7113" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.92388 -0.382683 0 2219.23 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2476" plane="-0.471382 -0.881929 -0 -1.69579" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.92388 -0.382683 0 2219.23 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2477" plane="-0.903997 0.427539 0 -0.259191" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.427541 -0.903996 0 108.836 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="60.2765 -49.3541 9.75" rot="1 0 0 0" scale="" transform="1 0 0 60.2765 0 1 0 -49.3541 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2479" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.09075 1.35522 0.75" />
                            <Vertex pos="-0.675053 -1.59088 0.75" />
                            <Vertex pos="0.649853 1.59088 0.75" />
                            <Vertex pos="-1.09075 -1.31312 0.75" />
                            <Vertex pos="1.09075 1.35522 -2.25" />
                            <Vertex pos="-0.675053 -1.59088 -2.25" />
                            <Vertex pos="0.649853 1.59088 -2.25" />
                            <Vertex pos="-1.09075 -1.31312 -2.25" />
                        </Vertices>
                        <Face id="2472" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 4145.69 0 -1 0 -1097.34 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2473" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 334.307 0 -1 0 -1097.34 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2474" plane="0.857731 -0.514098 0 -0.238854" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.514098 -0.857732 0 110.282 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2475" plane="0.47139 0.881925 -0 -1.70937" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.881921 -0.471398 0 2219.32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2476" plane="-0.555571 -0.831469 -0 -1.69781" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.881921 -0.471398 0 2219.32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2477" plane="-0.857727 0.514105 0 -0.260484" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.514105 -0.857727 0 108.714 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="0.723545 -49.3541 9.75" rot="1 0 0 0" scale="" transform="1 0 0 0.723545 0 1 0 -49.3541 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2479" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.675058 -1.59096 0.75" />
                            <Vertex pos="-1.09084 1.35525 0.75" />
                            <Vertex pos="1.09084 -1.31314 0.75" />
                            <Vertex pos="-0.649857 1.59096 0.75" />
                            <Vertex pos="0.675058 -1.59096 -2.25" />
                            <Vertex pos="-1.09084 1.35525 -2.25" />
                            <Vertex pos="1.09084 -1.31314 -2.25" />
                            <Vertex pos="-0.649858 1.59096 -2.25" />
                        </Vertices>
                        <Face id="2472" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 334.307 0 -1 0 -1097.33 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2473" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 4145.69 0 -1 0 -1097.33 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2474" plane="-0.857728 -0.514104 -0 -0.238904" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.514106 0.857726 0 109.546 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2475" plane="0.555575 -0.831466 0 -1.69788" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.831467 -0.555574 0 2219.36 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2476" plane="-0.471396 0.881922 1.59219e-007 -1.70944" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.831467 -0.555574 0 2219.36 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2477" plane="0.857722 0.514113 -0 -0.260535" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.514115 0.857722 0 107.977 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-0.881004 -46.3508 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -0.881004 0 1 0 -46.3508 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2479" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.513704 -1.64811 0.75" />
                            <Vertex pos="-0.954697 1.45679 0.75" />
                            <Vertex pos="0.954698 -1.4124 0.75" />
                            <Vertex pos="-0.492806 1.64811 0.75" />
                            <Vertex pos="0.513703 -1.64811 -2.25" />
                            <Vertex pos="-0.954697 1.45679 -2.25" />
                            <Vertex pos="0.954697 -1.4124 -2.25" />
                            <Vertex pos="-0.492807 1.64811 -2.25" />
                        </Vertices>
                        <Face id="2472" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 231.616 0 -1 0 -1289.55 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2473" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 4248.38 0 -1 0 -1289.55 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2474" plane="-0.904001 -0.42753 -0 -0.240227" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.42753 0.904001 0 109.409 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2475" plane="0.471387 -0.881926 -1.59216e-007 -1.69567" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.881921 -0.471396 0 2219.28 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2476" plane="-0.382681 0.923881 1.29254e-007 -1.71124" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.881921 -0.471396 0 2219.28 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2477" plane="0.90399 0.427553 -3.05331e-007 -0.259162" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.427553 0.90399 0 107.839 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="58.3852 -52.1855 9.75" rot="1 0 0 0" scale="" transform="1 0 0 58.3852 0 1 0 -52.1855 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2461" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.21626 1.24051 0.75" />
                            <Vertex pos="-0.829739 -1.51829 0.75" />
                            <Vertex pos="0.800529 1.51829 0.75" />
                            <Vertex pos="-1.21626 -1.20108 0.75" />
                            <Vertex pos="1.21626 1.24051 -2.25" />
                            <Vertex pos="-0.829739 -1.51829 -2.25" />
                            <Vertex pos="0.800529 1.51829 -2.25" />
                            <Vertex pos="-1.21626 -1.20108 -2.25" />
                        </Vertices>
                        <Face id="2454" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 4024.65 0 -1 0 -916.127 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2455" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 455.35 0 -1 0 -916.127 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2456" plane="0.803217 -0.595687 0 -0.237965" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.595686 -0.803217 0 110.138 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2457" plane="0.555567 0.831472 -0 -1.70716" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.831469 -0.555572 0 2219.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2458" plane="-0.634394 -0.77301 -0 -1.70003" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.831469 -0.555572 0 2219.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2459" plane="-0.803212 0.595693 0 -0.26144" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.595691 -0.803214 0 108.57 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="2.61485 -52.1855 9.75" rot="1 0 0 0" scale="" transform="1 0 0 2.61485 0 1 0 -52.1855 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2461" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.829742 -1.51821 0.75" />
                            <Vertex pos="-1.21625 1.24038 0.75" />
                            <Vertex pos="1.21625 -1.20101 0.75" />
                            <Vertex pos="-0.80046 1.51821 0.75" />
                            <Vertex pos="0.829742 -1.51821 -2.25" />
                            <Vertex pos="-1.21625 1.24038 -2.25" />
                            <Vertex pos="1.21625 -1.20101 -2.25" />
                            <Vertex pos="-0.80046 1.51821 -2.25" />
                        </Vertices>
                        <Face id="2454" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 455.35 0 -1 0 -916.128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2455" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 4024.65 0 -1 0 -916.128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2456" plane="-0.803196 -0.595715 -0 -0.237975" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.595715 0.803196 0 109.678 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2457" plane="0.634395 -0.773009 0 -1.69997" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.773012 -0.634392 0 2219.41 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2458" plane="-0.555581 0.831462 0 -1.70705" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.773012 -0.634392 0 2219.41 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2459" plane="0.803208 0.595699 -0 -0.261461" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.595699 0.803207 0 108.107 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="56.2253 -54.8177 9.75" rot="1 0 0 0" scale="" transform="1 0 0 56.2253 0 1 0 -54.8177 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2437" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.3301 1.11386 0.75" />
                            <Vertex pos="-0.976608 -1.43105 0.75" />
                            <Vertex pos="0.943592 1.43105 0.75" />
                            <Vertex pos="-1.3301 -1.07755 0.75" />
                            <Vertex pos="1.3301 1.11386 -2.25" />
                            <Vertex pos="-0.976608 -1.43105 -2.25" />
                            <Vertex pos="0.943592 1.43105 -2.25" />
                            <Vertex pos="-1.3301 -1.07755 -2.25" />
                        </Vertices>
                        <Face id="2430" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 3886.42 0 -1 0 -747.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2431" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 593.581 0 -1 0 -747.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2432" plane="0.740931 -0.671581 0 -0.237466" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.671582 -0.740931 0 109.988 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2433" plane="0.634382 0.773019 -0 -1.70483" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.77301 -0.634393 0 2219.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2434" plane="-0.707115 -0.707099 -0 -1.70247" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.77301 -0.634393 0 2219.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2435" plane="-0.740947 0.671564 0 -0.26189" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.671564 -0.740946 0 108.417 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="4.77475 -54.8176 9.75" rot="1 0 0 0" scale="" transform="1 0 0 4.77475 0 1 0 -54.8176 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2437" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.976652 -1.43115 0.75" />
                            <Vertex pos="-1.33015 1.11395 0.75" />
                            <Vertex pos="1.33015 -1.07765 0.75" />
                            <Vertex pos="-0.943645 1.43114 0.75" />
                            <Vertex pos="0.976652 -1.43115 -2.25" />
                            <Vertex pos="-1.33015 1.11395 -2.25" />
                            <Vertex pos="1.33015 -1.07765 -2.25" />
                            <Vertex pos="-0.943646 1.43114 -2.25" />
                        </Vertices>
                        <Face id="2430" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 593.584 0 -1 0 -747.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2431" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 3886.42 0 -1 0 -747.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2432" plane="-0.740943 -0.671568 -0 -0.237472" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.671567 0.740943 0 109.843 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2433" plane="0.707109 -0.707105 0 -1.70257" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.707104 -0.70711 0 2219.43 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2434" plane="-0.634385 0.773017 2.1427e-007 -1.70493" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.707104 -0.70711 0 2219.43 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2435" plane="0.740957 0.671553 -0 -0.261885" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.671552 0.740957 0 108.273 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="53.8176 -57.2253 9.75" rot="1 0 0 0" scale="" transform="1 0 0 53.8176 0 1 0 -57.2253 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.43105 0.976604 0.75" />
                            <Vertex pos="-1.11385 -1.3301 0.75" />
                            <Vertex pos="1.07756 1.3301 0.75" />
                            <Vertex pos="-1.43105 -0.943596 0.75" />
                            <Vertex pos="1.43105 0.976604 -2.25" />
                            <Vertex pos="-1.11385 -1.3301 -2.25" />
                            <Vertex pos="1.07756 1.3301 -2.25" />
                            <Vertex pos="-1.43105 -0.943596 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 3732.33 0 -1 0 -593.581 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 747.67 0 -1 0 -593.581 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="0.671582 -0.740931 0 -0.237471" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.740931 -0.671582 0 109.835 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.707113 0.707101 -0 -1.70247" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.707107 -0.707107 0 2219.43 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.773006 -0.634398 -0 -1.70483" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.707107 -0.707107 0 2219.43 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="-0.671563 0.740948 0 -0.261885" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.740946 -0.671564 0 108.266 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="51.1855 -59.3852 9.75" rot="1 0 0 0" scale="" transform="1 0 0 51.1855 0 1 0 -59.3852 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.51829 0.82975 0.75" />
                            <Vertex pos="-1.24051 -1.21625 0.75" />
                            <Vertex pos="1.2011 1.21626 0.75" />
                            <Vertex pos="-1.51828 -0.800529 0.75" />
                            <Vertex pos="1.51829 0.82975 -2.25" />
                            <Vertex pos="-1.24051 -1.21625 -2.25" />
                            <Vertex pos="1.2011 1.21626 -2.25" />
                            <Vertex pos="-1.51828 -0.800529 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 3563.87 0 -1 0 -455.35 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 916.127 0 -1 0 -455.35 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="0.595687 -0.803217 0 -0.237956" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.803217 -0.595686 0 109.682 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.773021 0.634381 -0 -1.70005" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.634393 -0.77301 0 2219.41 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.831475 -0.555562 -0 -1.70716" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.634393 -0.77301 0 2219.41 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="-0.595692 0.803213 0 -0.261431" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.803213 -0.595692 0 108.112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="48.3541 -61.2764 9.75" rot="1 0 0 0" scale="" transform="1 0 0 48.3541 0 1 0 -61.2764 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.59085 0.675049 0.75" />
                            <Vertex pos="-1.35514 -1.09076 0.75" />
                            <Vertex pos="1.31308 1.09076 0.75" />
                            <Vertex pos="-1.59085 -0.649776 0.75" />
                            <Vertex pos="1.59085 0.675049 -2.25" />
                            <Vertex pos="-1.35514 -1.09076 -2.25" />
                            <Vertex pos="1.31308 1.09076 -2.25" />
                            <Vertex pos="-1.59085 -0.649776 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 3382.67 0 -1 0 -334.308 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 1097.33 0 -1 0 -334.308 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="0.514114 -0.857722 0 -0.238873" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.857724 -0.514111 0 109.54 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.831469 0.555571 -0 -1.69778" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.555572 -0.831469 0 2219.36 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.881922 -0.471395 -0 -1.70931" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.555572 -0.831469 0 2219.36 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="-0.5141 0.85773 0 -0.260523" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.857732 -0.514097 0 107.968 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="45.3507 -62.881 9.75" rot="1 0 0 0" scale="" transform="1 0 0 45.3507 0 1 0 -62.881 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.64826 0.513798 0.75" />
                            <Vertex pos="-1.45694 -0.954796 0.75" />
                            <Vertex pos="1.41254 0.954796 0.75" />
                            <Vertex pos="-1.64826 -0.492916 0.75" />
                            <Vertex pos="1.64826 0.513798 -2.25" />
                            <Vertex pos="-1.45694 -0.954796 -2.25" />
                            <Vertex pos="1.41254 0.954796 -2.25" />
                            <Vertex pos="-1.64826 -0.492916 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 3190.45 0 -1 0 -231.615 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 1289.55 0 -1 0 -231.615 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="0.427542 -0.903996 0 -0.240229" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.903995 -0.427543 0 109.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.88192 0.471399 -0 -1.69584" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.4714 -0.88192 0 2219.28 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.923877 -0.382688 -0 -1.71142" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.4714 -0.88192 0 2219.28 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="-0.42757 0.903982 0 -0.259159" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.903984 -0.427566 0 107.851 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="42.2043 -64.1834 9.75" rot="1 0 0 0" scale="" transform="1 0 0 42.2043 0 1 0 -64.1834 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.68947 0.347599 0.75" />
                            <Vertex pos="-1.54433 -0.809502 0.75" />
                            <Vertex pos="1.49815 0.809498 0.75" />
                            <Vertex pos="-1.68948 -0.331017 0.75" />
                            <Vertex pos="1.68947 0.347599 -2.25" />
                            <Vertex pos="-1.54433 -0.809502 -2.25" />
                            <Vertex pos="1.49815 0.809498 -2.25" />
                            <Vertex pos="-1.68948 -0.331017 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 2989.08 0 -1 0 -148.262 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 1490.92 0 -1 0 -148.262 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="0.336897 -0.941541 0 -0.241899" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.941541 -0.336897 0 109.3 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.923883 0.382675 -0 -1.69389" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.38268 -0.923881 0 2219.17 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.956939 -0.29029 -0 -1.71282" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.38268 -0.923881 0 2219.17 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="-0.33688 0.941548 0 -0.257484" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.941548 -0.336878 0 107.731 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="38.9453 -65.171 9.75" rot="1 0 0 0" scale="" transform="1 0 0 38.9453 0 1 0 -65.171 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.71475 0.178062 0.75" />
                            <Vertex pos="-1.6172 -0.65654 0.75" />
                            <Vertex pos="1.5696 0.65654 0.75" />
                            <Vertex pos="-1.71474 -0.166153 0.75" />
                            <Vertex pos="1.71475 0.178062 -2.25" />
                            <Vertex pos="-1.6172 -0.65654 -2.25" />
                            <Vertex pos="1.5696 0.65654 -2.25" />
                            <Vertex pos="-1.71474 -0.166153 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 2780.5 0 -1 0 -85.0591 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 1699.5 0 -1 0 -85.0591 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="0.242978 -0.970032 0 -0.243921" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.970032 -0.242977 0 109.224 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.956937 0.290294 -0 -1.6926" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.290286 -0.95694 0 2219.05 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.980787 -0.195083 -0 -1.71421" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.290286 -0.95694 0 2219.05 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="-0.242983 0.970031 0 -0.255478" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.970031 -0.242981 0 107.657 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="35.6048 -65.8343 9.75" rot="1 0 0 0" scale="" transform="1 0 0 35.6048 0 1 0 -65.8343 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.72321 0.00679016 0.75" />
                            <Vertex pos="-1.67419 -0.497215 0.75" />
                            <Vertex pos="1.62566 0.497215 0.75" />
                            <Vertex pos="-1.72321 0.000411987 0.75" />
                            <Vertex pos="1.72321 0.00679016 -2.25" />
                            <Vertex pos="-1.67419 -0.497215 -2.25" />
                            <Vertex pos="1.62566 0.497215 -2.25" />
                            <Vertex pos="-1.72321 0.000411987 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 2566.71 0 -1 0 -42.6045 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 1913.29 0 -1 0 -42.6045 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="0.146744 -0.989174 0 -0.246155" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.989175 -0.146743 0 109.155 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.980786 0.195087 -0 -1.69142" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.195087 -0.980786 0 2218.91 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.995183 -0.0980329 -0 -1.71487" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.195087 -0.980786 0 2218.91 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="-0.146744 0.989175 0 -0.253277" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.989175 -0.146742 0 107.586 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="32.2153 -66.167 9.75" rot="1 0 0 0" scale="" transform="1 0 0 32.2153 0 1 0 -66.167 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.71539 -0.164551 0.75" />
                            <Vertex pos="-1.71539 -0.333054 0.75" />
                            <Vertex pos="1.66638 0.333054 0.75" />
                            <Vertex pos="-1.71539 0.166954 0.75" />
                            <Vertex pos="1.71539 -0.164551 -2.25" />
                            <Vertex pos="-1.71539 -0.333054 -2.25" />
                            <Vertex pos="1.66638 0.333054 -2.25" />
                            <Vertex pos="-1.71539 0.166954 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 2349.78 0 -1 0 -21.3149 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 2130.22 0 -1 0 -21.3149 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="0.0490559 -0.998796 0 -0.248503" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.998796 -0.0490549 0 109.136 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.995185 0.0980173 -0 -1.691" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.0980185 -0.995185 0 2218.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-1 -0 -0 -1.71539" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0.0980185 -0.995185 0 2218.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="-0.0490572 0.998796 0 -0.250905" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.998796 -0.0490571 0 107.565 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="28.7847 -66.167 9.75" rot="1 0 0 0" scale="" transform="1 0 0 28.7847 0 1 0 -66.167 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.71521 -0.333054 0.75" />
                            <Vertex pos="-1.71521 -0.164558 0.75" />
                            <Vertex pos="1.71521 0.166939 0.75" />
                            <Vertex pos="-1.6662 0.333046 0.75" />
                            <Vertex pos="1.71521 -0.333054 -2.25" />
                            <Vertex pos="-1.71521 -0.164558 -2.25" />
                            <Vertex pos="1.71521 0.166939 -2.25" />
                            <Vertex pos="-1.6662 0.333046 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 2130.22 0 -1 0 -21.3145 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 2349.78 0 -1 0 -21.3145 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="-0.049059 -0.998796 -0 -0.248506" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.998796 0.0490598 0 110.687 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="1 0 0 -1.71521" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0 -1 0 2218.69 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.995185 0.0980175 0 -1.69082" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 0 -1 0 2218.69 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="0.0490644 0.998796 -0 -0.250894" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.998796 0.0490621 0 109.117 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="25.3951 -65.8343 9.75" rot="1 0 0 0" scale="" transform="1 0 0 25.3951 0 1 0 -65.8343 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.67437 -0.497185 0.75" />
                            <Vertex pos="-1.72338 0.00682068 0.75" />
                            <Vertex pos="1.72338 0.000396729 0.75" />
                            <Vertex pos="-1.62583 0.497192 0.75" />
                            <Vertex pos="1.67437 -0.497185 -2.25" />
                            <Vertex pos="-1.72338 0.00682068 -2.25" />
                            <Vertex pos="1.72338 0.000396729 -2.25" />
                            <Vertex pos="-1.62583 0.497192 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 1913.29 0 -1 0 -42.6035 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 2566.71 0 -1 0 -42.6035 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="-0.14673 -0.989177 -0 -0.246124" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.989177 0.146729 0 110.668 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.995184 -0.0980219 0 -1.71504" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.0980159 -0.995185 0 2218.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.980782 0.195108 0 -1.69159" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.0980159 -0.995185 0 2218.84 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="0.146727 0.989177 -0 -0.253258" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.989177 0.146728 0 109.098 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="22.0547 -65.171 9.75" rot="1 0 0 0" scale="" transform="1 0 0 22.0547 0 1 0 -65.171 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.61703 -0.656502 0.75" />
                            <Vertex pos="-1.71458 0.178108 0.75" />
                            <Vertex pos="1.71458 -0.1661 0.75" />
                            <Vertex pos="-1.56946 0.656509 0.75" />
                            <Vertex pos="1.61703 -0.656502 -2.25" />
                            <Vertex pos="-1.71458 0.178108 -2.25" />
                            <Vertex pos="1.71458 -0.1661 -2.25" />
                            <Vertex pos="-1.56946 0.656509 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 1699.5 0 -1 0 -85.0547 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 2780.5 0 -1 0 -85.0547 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="-0.243003 -0.970025 -0 -0.24388" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.970026 0.243001 0 110.597 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.980784 -0.195096 0 -1.71404" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.195094 -0.980785 0 2218.99 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.956941 0.290282 0 -1.69245" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.195094 -0.980785 0 2218.99 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="0.24298 0.970031 -0 -0.255487" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.970032 0.242978 0 109.026 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="18.7956 -64.1833 9.75" rot="1 0 0 0" scale="" transform="1 0 0 18.7956 0 1 0 -64.1833 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.54454 -0.809563 0.75" />
                            <Vertex pos="-1.68966 0.347641 0.75" />
                            <Vertex pos="1.68966 -0.331169 0.75" />
                            <Vertex pos="-1.49832 0.809563 0.75" />
                            <Vertex pos="1.54454 -0.809563 -2.25" />
                            <Vertex pos="-1.68966 0.347641 -2.25" />
                            <Vertex pos="1.68966 -0.331169 -2.25" />
                            <Vertex pos="-1.49832 0.809563 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 1490.92 0 -1 0 -148.266 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 2989.08 0 -1 0 -148.266 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="-0.336887 -0.941545 -0 -0.241905" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.941546 0.336885 0 110.527 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.95694 -0.290286 0 -1.71304" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.290283 -0.956941 0 2219.11 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.923876 0.382693 0 -1.69408" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.290283 -0.956941 0 2219.11 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="0.336904 0.941539 -0 -0.257445" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.941539 0.336903 0 108.956 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="15.6492 -62.881 9.75" rot="1 0 0 0" scale="" transform="1 0 0 15.6492 0 1 0 -62.881 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.45673 -0.954708 0.75" />
                            <Vertex pos="-1.64807 0.513798 0.75" />
                            <Vertex pos="1.64807 -0.492771 0.75" />
                            <Vertex pos="-1.4124 0.954708 0.75" />
                            <Vertex pos="1.45673 -0.954708 -2.25" />
                            <Vertex pos="-1.64807 0.513798 -2.25" />
                            <Vertex pos="1.64807 -0.492771 -2.25" />
                            <Vertex pos="-1.4124 0.954708 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 1289.55 0 -1 0 -231.616 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 3190.45 0 -1 0 -231.616 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="-0.427566 -0.903984 -0 -0.240193" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.903985 0.427565 0 110.404 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.92388 -0.382682 0 -1.71119" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.382689 -0.923877 0 2219.23 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.881922 0.471395 0 -1.69567" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.382689 -0.923877 0 2219.23 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="0.427551 0.903991 -0 -0.259174" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.90399 0.427553 0 108.838 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="12.6458 -61.2764 9.75" rot="1 0 0 0" scale="" transform="1 0 0 12.6458 0 1 0 -61.2764 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.35526 -1.09081 0.75" />
                            <Vertex pos="-1.59093 0.675087 0.75" />
                            <Vertex pos="1.59093 -0.649899 0.75" />
                            <Vertex pos="-1.31317 1.09081 0.75" />
                            <Vertex pos="1.35526 -1.09081 -2.25" />
                            <Vertex pos="-1.59093 0.675087 -2.25" />
                            <Vertex pos="1.59093 -0.649899 -2.25" />
                            <Vertex pos="-1.31317 1.09081 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 1097.33 0 -1 0 -334.311 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 3382.67 0 -1 0 -334.311 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="-0.514107 -0.857726 -0 -0.238868" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.857726 0.514106 0 110.287 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.881923 -0.471394 0 -1.70944" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.471398 -0.881921 0 2219.32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.831486 0.555547 0 -1.69788" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.471398 -0.881921 0 2219.32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="0.514115 0.857721 -0 -0.26049" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.857722 0.514115 0 108.719 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="9.81443 -59.3851 9.75" rot="1 0 0 0" scale="" transform="1 0 0 9.81443 0 1 0 -59.3851 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.24046 -1.2162 0.75" />
                            <Vertex pos="-1.51823 0.829693 0.75" />
                            <Vertex pos="1.51823 -0.800488 0.75" />
                            <Vertex pos="-1.20104 1.21619 0.75" />
                            <Vertex pos="1.24046 -1.2162 -2.25" />
                            <Vertex pos="-1.51823 0.829693 -2.25" />
                            <Vertex pos="1.51823 -0.800488 -2.25" />
                            <Vertex pos="-1.20104 1.21619 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 916.124 0 -1 0 -455.354 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 3563.88 0 -1 0 -455.354 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="-0.595682 -0.80322 -0 -0.237956" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.80322 0.595682 0 110.133 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.83147 -0.55557 0 -1.70709" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.555575 -0.831466 0 2219.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.77301 0.634393 0 -1.69996" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.555575 -0.831466 0 2219.39 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="0.595686 0.803217 -0 -0.261422" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.803217 0.595686 0 108.566 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="7.1824 -57.2253 9.75" rot="1 0 0 0" scale="" transform="1 0 0 7.1824 0 1 0 -57.2253 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="2419" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.11381 -1.33006 0.75" />
                            <Vertex pos="-1.431 0.976551 0.75" />
                            <Vertex pos="1.431 -0.943542 0.75" />
                            <Vertex pos="-1.0775 1.33006 0.75" />
                            <Vertex pos="1.11381 -1.33006 -2.25" />
                            <Vertex pos="-1.431 0.976551 -2.25" />
                            <Vertex pos="1.431 -0.943542 -2.25" />
                            <Vertex pos="-1.0775 1.33006 -2.25" />
                        </Vertices>
                        <Face id="2412" plane="0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 747.674 0 -1 0 -593.578 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2413" plane="0 0 -1 -2.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 3732.33 0 -1 0 -593.578 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2414" plane="-0.67158 -0.740932 -0 -0.237472" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.740933 0.671579 0 109.983 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2415" plane="0.773027 -0.634373 0 -1.70476" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.634393 -0.77301 0 2219.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2416" plane="-0.707116 0.707098 0 -1.7024" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.634393 -0.77301 0 2219.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="2417" plane="0.671564 0.740947 -0 -0.261894" album="PQ" material="pq_wood_2" texgens="0 0 -1 144 -0.740947 0.671564 0 108.413 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="56.6874 -32.7987 8" rot="1 0 0 0" scale="" transform="1 0 0 56.6874 0 1 0 -32.7987 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="541" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.312595 1.29873 0.5" />
                            <Vertex pos="0.184998 -1.29873 0.5" />
                            <Vertex pos="-0.187397 1.29873 0.5" />
                            <Vertex pos="-0.312599 -1.24972 0.5" />
                            <Vertex pos="0.312595 1.29873 -0.5" />
                            <Vertex pos="0.184998 -1.29873 -0.5" />
                            <Vertex pos="-0.187397 1.29873 -0.5" />
                            <Vertex pos="-0.312599 -1.24972 -0.5" />
                        </Vertices>
                        <Face id="534" plane="-0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 3371.99 0 -1 0 -1612.88 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="535" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 20.0059 0 -1 0 -1612.88 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="536" plane="0.998796 -0.0490646 0 -0.248497" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.0490657 -0.998796 0 84.0002 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="537" plane="0 1 -0 -1.29873" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 1 0 0 1675.99 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="538" plane="-0.0980191 -0.995185 -0 -1.27434" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 1 0 0 1675.99 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="539" plane="-0.998795 0.0490695 0 -0.250899" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.0490689 -0.998796 0 82.43 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="56.4364 -35.3592 8" rot="1 0 0 0" scale="" transform="1 0 0 56.4364 0 1 0 -35.3592 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="541" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.435997 1.26173 0.5" />
                            <Vertex pos="0.0543938 -1.31073 0.5" />
                            <Vertex pos="-0.0615959 1.31073 0.5" />
                            <Vertex pos="-0.435997 -1.21319 0.5" />
                            <Vertex pos="0.435997 1.26173 -0.5" />
                            <Vertex pos="0.0543938 -1.31073 -0.5" />
                            <Vertex pos="-0.0615959 1.31073 -0.5" />
                            <Vertex pos="-0.435997 -1.21319 -0.5" />
                        </Vertices>
                        <Face id="534" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 3355.93 0 -1 0 -1449.01 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="535" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 36.0698 0 -1 0 -1449.01 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="536" plane="0.989176 -0.146736 0 -0.246136" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.146735 -0.989176 0 83.9707 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="537" plane="0.0980001 0.995186 -0 -1.29838" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.995185 -0.0980173 0 1676.15 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="538" plane="-0.195081 -0.980787 -0 -1.27494" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.995185 -0.0980173 0 1676.15 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="539" plane="-0.989176 0.146735 0 -0.25326" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.146735 -0.989176 0 82.4004 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="4.5636 -35.3592 8" rot="1 0 0 0" scale="" transform="1 0 0 4.5636 0 1 0 -35.3592 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="541" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0544019 -1.31079 0.5" />
                            <Vertex pos="-0.436003 1.26178 0.5" />
                            <Vertex pos="0.436003 -1.21325 0.5" />
                            <Vertex pos="0.0616035 1.31079 0.5" />
                            <Vertex pos="-0.0544019 -1.31079 -0.5" />
                            <Vertex pos="-0.436003 1.26178 -0.5" />
                            <Vertex pos="0.436003 -1.21325 -0.5" />
                            <Vertex pos="0.0616035 1.31079 -0.5" />
                        </Vertices>
                        <Face id="534" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 36.0703 0 -1 0 -1449.01 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="535" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 3355.93 0 -1 0 -1449.01 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="536" plane="-0.989177 -0.146729 -0 -0.246144" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.146728 0.989177 0 82.4715 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="537" plane="0.195076 -0.980788 0 -1.27499" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.980785 -0.195093 0 1676.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="538" plane="-0.0980171 0.995185 0 -1.29844" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.980785 -0.195093 0 1676.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="539" plane="0.989177 0.146728 -0 -0.253266" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.146728 0.989177 0 80.9016 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="4.3126 -32.7987 8" rot="1 0 0 0" scale="" transform="1 0 0 4.3126 0 1 0 -32.7987 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="541" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.185 -1.29867 0.5" />
                            <Vertex pos="-0.3126 1.29867 0.5" />
                            <Vertex pos="0.3126 -1.24966 0.5" />
                            <Vertex pos="0.1874 1.29867 0.5" />
                            <Vertex pos="-0.185 -1.29867 -0.5" />
                            <Vertex pos="-0.3126 1.29867 -0.5" />
                            <Vertex pos="0.3126 -1.24966 -0.5" />
                            <Vertex pos="0.1874 1.29867 -0.5" />
                        </Vertices>
                        <Face id="534" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 20.0062 0 -1 0 -1612.88 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="535" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 3371.99 0 -1 0 -1612.88 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="536" plane="-0.998795 -0.049068 -0 -0.2485" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.0490679 0.998796 0 82.4334 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="537" plane="0.0980186 -0.995185 0 -1.27428" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.995185 -0.0980151 0 1676.07 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="538" plane="0 1 0 -1.29867" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.995185 -0.0980151 0 1676.07 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="539" plane="0.998795 0.049071 -0 -0.250901" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.0490714 0.998796 0 80.8632 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="55.9357 -37.8825 8" rot="1 0 0 0" scale="" transform="1 0 0 55.9357 0 1 0 -37.8825 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="535" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.555157 1.21254 0.5" />
                            <Vertex pos="-0.0767441 -1.31009 0.5" />
                            <Vertex pos="0.0647507 1.31009 0.5" />
                            <Vertex pos="-0.555153 -1.16497 0.5" />
                            <Vertex pos="0.555157 1.21254 -0.5" />
                            <Vertex pos="-0.0767441 -1.31009 -0.5" />
                            <Vertex pos="0.0647507 1.31009 -0.5" />
                            <Vertex pos="-0.555153 -1.16497 -0.5" />
                        </Vertices>
                        <Face id="528" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 3323.88 0 -1 0 -1287.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="529" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 68.1182 0 -1 0 -1287.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="530" plane="0.97003 -0.242986 0 -0.243889" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.242986 -0.97003 0 83.9105 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="531" plane="0.195094 0.980785 -0 -1.29755" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.980785 -0.195091 0 1676.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="532" plane="-0.290278 -0.956942 -0 -1.27596" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.980785 -0.195091 0 1676.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="533" plane="-0.970037 0.242956 0 -0.255483" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.242957 -0.970037 0 82.3408 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="55.1899 -40.3443 8" rot="1 0 0 0" scale="" transform="1 0 0 55.1899 0 1 0 -40.3443 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="535" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.669003 1.15171 0.5" />
                            <Vertex pos="-0.207096 -1.29684 0.5" />
                            <Vertex pos="0.190594 1.29684 0.5" />
                            <Vertex pos="-0.668999 -1.10552 0.5" />
                            <Vertex pos="0.669003 1.15171 -0.5" />
                            <Vertex pos="-0.207096 -1.29684 -0.5" />
                            <Vertex pos="0.190594 1.29684 -0.5" />
                            <Vertex pos="-0.668999 -1.10552 -0.5" />
                        </Vertices>
                        <Face id="528" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 3276.15 0 -1 0 -1129.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="529" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 115.846 0 -1 0 -1129.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="530" plane="0.941545 -0.336888 0 -0.241899" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.336887 -0.941545 0 83.8256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="531" plane="0.290296 0.956937 -0 -1.29632" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.956941 -0.290285 0 1676.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="532" plane="-0.382672 -0.923884 -0 -1.27738" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.956941 -0.290285 0 1676.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="533" plane="-0.941542 0.336895 0 -0.257447" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.336895 -0.941542 0 82.2573 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="54.2064 -42.7209 8" rot="1 0 0 0" scale="" transform="1 0 0 54.2064 0 1 0 -42.7209 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="535" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.776409 1.07978 0.5" />
                            <Vertex pos="-0.335491 -1.27111 0.5" />
                            <Vertex pos="0.314499 1.27111 0.5" />
                            <Vertex pos="-0.776409 -1.03544 0.5" />
                            <Vertex pos="0.776409 1.07978 -0.5" />
                            <Vertex pos="-0.335491 -1.27111 -0.5" />
                            <Vertex pos="0.314499 1.27111 -0.5" />
                            <Vertex pos="-0.776409 -1.03544 -0.5" />
                        </Vertices>
                        <Face id="528" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 3213.21 0 -1 0 -977.863 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="529" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 178.791 0 -1 0 -977.863 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="530" plane="0.903988 -0.427559 0 -0.240195" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.427557 -0.903988 0 83.7168 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="531" plane="0.382685 0.923879 -0 -1.29471" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.92388 -0.382683 0 1676.54 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="532" plane="-0.471388 -0.881926 -0 -1.27917" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.92388 -0.382683 0 1676.54 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="533" plane="-0.903991 0.427552 0 -0.259162" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.427553 -0.90399 0 82.1471 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="6.79361 -42.7209 8" rot="1 0 0 0" scale="" transform="1 0 0 6.79361 0 1 0 -42.7209 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="535" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.335496 -1.27109 0.5" />
                            <Vertex pos="-0.776409 1.07972 0.5" />
                            <Vertex pos="0.776409 -1.03541 0.5" />
                            <Vertex pos="-0.31442 1.27109 0.5" />
                            <Vertex pos="0.335496 -1.27109 -0.5" />
                            <Vertex pos="-0.776409 1.07972 -0.5" />
                            <Vertex pos="0.776409 -1.03541 -0.5" />
                            <Vertex pos="-0.31442 1.27109 -0.5" />
                        </Vertices>
                        <Face id="528" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 178.791 0 -1 0 -977.861 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="529" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 3213.21 0 -1 0 -977.861 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="530" plane="-0.903981 -0.427572 -0 -0.240201" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.427573 0.903981 0 82.7185 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="531" plane="0.471408 -0.881915 0 -1.27915" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.881922 -0.471397 0 1676.59 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="532" plane="-0.382697 0.923874 0 -1.29465" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.881922 -0.471397 0 1676.59 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="533" plane="0.903999 0.427535 -0 -0.259199" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.427534 0.903999 0 81.1464 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="5.81015 -40.3443 8" rot="1 0 0 0" scale="" transform="1 0 0 5.81015 0 1 0 -40.3443 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="535" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.207053 -1.29691 0.5" />
                            <Vertex pos="-0.669045 1.15178 0.5" />
                            <Vertex pos="0.669045 -1.10555 0.5" />
                            <Vertex pos="-0.190639 1.29691 0.5" />
                            <Vertex pos="0.207053 -1.29691 -0.5" />
                            <Vertex pos="-0.669045 1.15178 -0.5" />
                            <Vertex pos="0.669045 -1.10555 -0.5" />
                            <Vertex pos="-0.190639 1.29691 -0.5" />
                        </Vertices>
                        <Face id="528" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 115.849 0 -1 0 -1129.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="529" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 3276.15 0 -1 0 -1129.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="530" plane="-0.941551 -0.33687 -0 -0.241939" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.33687 0.941551 0 82.615 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="531" plane="0.382678 -0.923882 0 -1.27743" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.923878 -0.382686 0 1676.48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="532" plane="-0.290298 0.956936 0 -1.2964" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.923878 -0.382686 0 1676.48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="533" plane="0.941535 0.336914 -0 -0.257454" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.336915 0.941535 0 81.0463 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="5.06435 -37.8825 8" rot="1 0 0 0" scale="" transform="1 0 0 5.06435 0 1 0 -37.8825 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="535" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0767484 -1.31004 0.5" />
                            <Vertex pos="-0.555151 1.21249 0.5" />
                            <Vertex pos="0.555151 -1.16492 0.5" />
                            <Vertex pos="-0.0647554 1.31004 0.5" />
                            <Vertex pos="0.0767484 -1.31004 -0.5" />
                            <Vertex pos="-0.555151 1.21249 -0.5" />
                            <Vertex pos="0.555151 -1.16492 -0.5" />
                            <Vertex pos="-0.0647554 1.31004 -0.5" />
                        </Vertices>
                        <Face id="528" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 68.1187 0 -1 0 -1287.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="529" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 3323.88 0 -1 0 -1287.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="530" plane="-0.970028 -0.242994 -0 -0.243884" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.242995 0.970028 0 82.5228 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="531" plane="0.290281 -0.956941 0 -1.27591" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.956941 -0.290283 0 1676.36 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="532" plane="-0.195099 0.980784 0 -1.2975" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.956941 -0.290283 0 1676.36 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="533" plane="0.970035 0.242966 -0 -0.25548" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.242966 0.970035 0 80.9517 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="52.9945 -44.9895 8" rot="1 0 0 0" scale="" transform="1 0 0 52.9945 0 1 0 -44.9895 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="523" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.876358 0.997463 0.5" />
                            <Vertex pos="-0.46064 -1.23314 0.5" />
                            <Vertex pos="0.435448 1.23314 0.5" />
                            <Vertex pos="-0.876358 -0.955368 0.5" />
                            <Vertex pos="0.876358 0.997463 -0.5" />
                            <Vertex pos="-0.46064 -1.23314 -0.5" />
                            <Vertex pos="0.435448 1.23314 -0.5" />
                            <Vertex pos="-0.876358 -0.955368 -0.5" />
                        </Vertices>
                        <Face id="516" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 3135.65 0 -1 0 -832.674 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="517" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 256.349 0 -1 0 -832.674 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="518" plane="0.857724 -0.51411 0 -0.238868" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.514112 -0.857723 0 83.5901 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="519" plane="0.471406 0.881917 -0 -1.2928" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.881922 -0.471397 0 1676.63 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="520" plane="-0.555568 -0.831471 -0 -1.28124" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.881922 -0.471397 0 1676.63 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="521" plane="-0.857717 0.514121 0 -0.260492" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.514121 -0.857718 0 82.0215 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="8.00546 -44.9895 8" rot="1 0 0 0" scale="" transform="1 0 0 8.00546 0 1 0 -44.9895 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="523" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.460637 -1.23319 0.5" />
                            <Vertex pos="-0.876357 0.997505 0.5" />
                            <Vertex pos="0.876357 -0.955406 0.5" />
                            <Vertex pos="-0.435438 1.23318 0.5" />
                            <Vertex pos="0.460637 -1.23319 -0.5" />
                            <Vertex pos="-0.876357 0.997505 -0.5" />
                            <Vertex pos="0.876357 -0.955406 -0.5" />
                            <Vertex pos="-0.435438 1.23318 -0.5" />
                        </Vertices>
                        <Face id="516" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 256.349 0 -1 0 -832.671 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="517" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 3135.65 0 -1 0 -832.671 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="518" plane="-0.857734 -0.514093 -0 -0.238871" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.514094 0.857734 0 82.8517 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="519" plane="0.555582 -0.831462 0 -1.28127" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.831468 -0.555573 0 1676.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="520" plane="-0.471395 0.881922 0 -1.29283" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.831468 -0.555573 0 1676.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="521" plane="0.857727 0.514105 -0 -0.260497" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.514104 0.857728 0 81.2793 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="260" owner="0" type="0" pos="51.5661 -47.1281 8" rot="1 0 0 0" scale="" transform="1 0 0 51.5661 0 1 0 -47.1281 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="517" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.967793 0.905521 0.5" />
                            <Vertex pos="-0.581303 -1.18328 0.5" />
                            <Vertex pos="0.552094 1.18328 0.5" />
                            <Vertex pos="-0.967796 -0.866093 0.5" />
                            <Vertex pos="0.967793 0.905521 -0.5" />
                            <Vertex pos="-0.581303 -1.18328 -0.5" />
                            <Vertex pos="0.552094 1.18328 -0.5" />
                            <Vertex pos="-0.967796 -0.866093 -0.5" />
                        </Vertices>
                        <Face id="510" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 3044.23 0 -1 0 -695.801 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="511" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 347.77 0 -1 0 -695.801 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="512" plane="0.803219 -0.595683 0 -0.237946" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.595684 -0.803219 0 83.4451 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="513" plane="0.555567 0.831472 -0 -1.29059" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.831469 -0.555571 0 1676.69 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="514" plane="-0.634394 -0.77301 -0 -1.28346" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.831469 -0.555571 0 1676.69 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="515" plane="-0.803213 0.595692 0 -0.261422" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.595689 -0.803215 0 81.8775 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="261" owner="0" type="0" pos="9.4339 -47.1282 8" rot="1 0 0 0" scale="" transform="1 0 0 9.4339 0 1 0 -47.1282 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="517" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.581298 -1.18324 0.5" />
                            <Vertex pos="-0.967804 0.90546 0.5" />
                            <Vertex pos="0.967805 -0.866039 0.5" />
                            <Vertex pos="-0.55208 1.18324 0.5" />
                            <Vertex pos="0.581298 -1.18324 -0.5" />
                            <Vertex pos="-0.967804 0.90546 -0.5" />
                            <Vertex pos="0.967805 -0.866039 -0.5" />
                            <Vertex pos="-0.55208 1.18324 -0.5" />
                        </Vertices>
                        <Face id="510" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 347.769 0 -1 0 -695.798 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="511" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 3044.23 0 -1 0 -695.798 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="512" plane="-0.803205 -0.595703 -0 -0.237959" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.595703 0.803205 0 82.9867 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="513" plane="0.634397 -0.773008 0 -1.28343" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.773011 -0.634392 0 1676.72 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="514" plane="-0.555573 0.831468 0 -1.29055" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.773011 -0.634392 0 1676.72 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="515" plane="0.803201 0.595708 -0 -0.261435" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.595708 0.803201 0 81.4164 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="264" owner="0" type="0" pos="49.9348 -49.1163 8" rot="1 0 0 0" scale="" transform="1 0 0 49.9348 0 1 0 -49.1163 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="505" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.05 0.804855 0.5" />
                            <Vertex pos="-0.696503 -1.12204 0.5" />
                            <Vertex pos="0.663502 1.12204 0.5" />
                            <Vertex pos="-1.05 -0.768551 0.5" />
                            <Vertex pos="1.05 0.804855 -0.5" />
                            <Vertex pos="-0.696503 -1.12204 -0.5" />
                            <Vertex pos="0.663502 1.12204 -0.5" />
                            <Vertex pos="-1.05 -0.768551 -0.5" />
                        </Vertices>
                        <Face id="498" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 2939.83 0 -1 0 -568.56 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="499" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 452.173 0 -1 0 -568.56 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="500" plane="0.740938 -0.671573 0 -0.237466" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.671571 -0.74094 0 83.2959 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="501" plane="0.634387 0.773016 -0 -1.28827" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.773011 -0.634392 0 1676.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="502" plane="-0.707099 -0.707115 -0 -1.28591" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.773011 -0.634392 0 1676.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="503" plane="-0.740957 0.671553 0 -0.261882" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.67155 -0.740959 0 81.7261 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="265" owner="0" type="0" pos="11.0652 -49.1163 8" rot="1 0 0 0" scale="" transform="1 0 0 11.0652 0 1 0 -49.1163 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="505" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.696549 -1.1221 0.5" />
                            <Vertex pos="-1.05005 0.804901 0.5" />
                            <Vertex pos="1.05005 -0.768597 0.5" />
                            <Vertex pos="-0.663546 1.1221 0.5" />
                            <Vertex pos="0.696549 -1.1221 -0.5" />
                            <Vertex pos="-1.05005 0.804901 -0.5" />
                            <Vertex pos="1.05005 -0.768597 -0.5" />
                            <Vertex pos="-0.663546 1.1221 -0.5" />
                        </Vertices>
                        <Face id="498" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 452.176 0 -1 0 -568.557 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="499" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 2939.82 0 -1 0 -568.557 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="500" plane="-0.740938 -0.671573 -0 -0.237472" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.671573 0.740938 0 83.1482 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="501" plane="0.707109 -0.707105 0 -1.28598" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.707103 -0.707111 0 1676.74 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="502" plane="-0.634397 0.773007 0 -1.28834" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.707103 -0.707111 0 1676.74 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="503" plane="0.740957 0.671552 -0 -0.261889" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.671552 0.740957 0 81.5784 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="268" owner="0" type="0" pos="48.1162 -50.9348 8" rot="1 0 0 0" scale="" transform="1 0 0 48.1162 0 1 0 -50.9348 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="487" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.12205 0.696499 0.5" />
                            <Vertex pos="-0.804855 -1.05 0.5" />
                            <Vertex pos="0.768547 1.05 0.5" />
                            <Vertex pos="-1.12205 -0.663498 0.5" />
                            <Vertex pos="1.12205 0.696499 -0.5" />
                            <Vertex pos="-0.804855 -1.05 -0.5" />
                            <Vertex pos="0.768547 1.05 -0.5" />
                            <Vertex pos="-1.12205 -0.663498 -0.5" />
                        </Vertices>
                        <Face id="480" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 2823.44 0 -1 0 -452.173 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="481" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 568.56 0 -1 0 -452.173 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="482" plane="0.67157 -0.740941 0 -0.237471" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.74094 -0.671571 0 83.1436 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="483" plane="0.707105 0.707109 -0 -1.28591" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.707107 -0.707107 0 1676.74 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="484" plane="-0.773009 -0.634395 -0 -1.28827" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.707107 -0.707107 0 1676.74 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="485" plane="-0.67155 0.740959 0 -0.261889" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.740959 -0.67155 0 81.5737 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="269" owner="0" type="0" pos="12.8838 -50.9348 8" rot="1 0 0 0" scale="" transform="1 0 0 12.8838 0 1 0 -50.9348 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="487" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.804801 -1.04995 0.5" />
                            <Vertex pos="-1.122 0.696449 0.5" />
                            <Vertex pos="1.122 -0.663445 0.5" />
                            <Vertex pos="-0.768497 1.04995 0.5" />
                            <Vertex pos="0.804801 -1.04995 -0.5" />
                            <Vertex pos="-1.122 0.696449 -0.5" />
                            <Vertex pos="1.122 -0.663445 -0.5" />
                            <Vertex pos="-0.768497 1.04995 -0.5" />
                        </Vertices>
                        <Face id="480" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 568.563 0 -1 0 -452.17 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="481" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 2823.44 0 -1 0 -452.17 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="482" plane="-0.671569 -0.740942 -0 -0.237472" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.740942 0.67157 0 83.2915 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="483" plane="0.773008 -0.634396 0 -1.2882" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.634392 -0.773011 0 1676.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="484" plane="-0.707105 0.707109 0 -1.28584" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.634392 -0.773011 0 1676.73 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="485" plane="0.671548 0.740961 -0 -0.26189" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.740961 0.671548 0 81.7219 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="272" owner="0" type="0" pos="46.1281 -52.5661 8" rot="1 0 0 0" scale="" transform="1 0 0 46.1281 0 1 0 -52.5661 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.18328 0.58131 0.5" />
                            <Vertex pos="-0.905514 -0.967793 0.5" />
                            <Vertex pos="0.866104 0.967793 0.5" />
                            <Vertex pos="-1.18328 -0.552094 0.5" />
                            <Vertex pos="1.18328 0.58131 -0.5" />
                            <Vertex pos="-0.905514 -0.967793 -0.5" />
                            <Vertex pos="0.866104 0.967793 -0.5" />
                            <Vertex pos="-1.18328 -0.552094 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 2696.2 0 -1 0 -347.769 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 695.801 0 -1 0 -347.769 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="0.595686 -0.803217 0 -0.237946" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.803219 -0.595684 0 82.9896 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.773013 0.63439 -0 -1.28347" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.634392 -0.773011 0 1676.72 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.831465 -0.555577 -0 -1.29059" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.634392 -0.773011 0 1676.72 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="-0.595689 0.803215 0 -0.261417" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.803215 -0.595689 0 81.4186 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="273" owner="0" type="0" pos="43.9895 -53.9945 8" rot="1 0 0 0" scale="" transform="1 0 0 43.9895 0 1 0 -53.9945 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.23311 0.46064 0.5" />
                            <Vertex pos="-0.997387 -0.876354 0.5" />
                            <Vertex pos="0.955341 0.876354 0.5" />
                            <Vertex pos="-1.2331 -0.435371 0.5" />
                            <Vertex pos="1.23311 0.46064 -0.5" />
                            <Vertex pos="-0.997387 -0.876354 -0.5" />
                            <Vertex pos="0.955341 0.876354 -0.5" />
                            <Vertex pos="-1.2331 -0.435371 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 2559.33 0 -1 0 -256.349 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 832.672 0 -1 0 -256.349 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="0.514127 -0.857714 0 -0.238878" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.857714 -0.514128 0 82.847 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.831472 0.555567 -0 -1.28121" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.555571 -0.831469 0 1676.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.881919 -0.471401 -0 -1.29273" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.555571 -0.831469 0 1676.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="-0.51411 0.857724 0 -0.26052" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.857725 -0.514109 0 81.2753 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="274" owner="0" type="0" pos="41.7209 -55.2064 8" rot="1 0 0 0" scale="" transform="1 0 0 41.7209 0 1 0 -55.2064 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.27121 0.335464 0.5" />
                            <Vertex pos="-1.0799 -0.77644 0.5" />
                            <Vertex pos="1.0355 0.77644 0.5" />
                            <Vertex pos="-1.27121 -0.314568 0.5" />
                            <Vertex pos="1.27121 0.335464 -0.5" />
                            <Vertex pos="-1.0799 -0.77644 -0.5" />
                            <Vertex pos="1.0355 0.77644 -0.5" />
                            <Vertex pos="-1.27121 -0.314568 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 2414.14 0 -1 0 -178.793 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 977.863 0 -1 0 -178.793 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="0.427527 -0.904002 0 -0.240217" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.904002 -0.427527 0 82.726 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.881918 0.471402 -0 -1.27924" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.4714 -0.88192 0 1676.58 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.923882 -0.382677 -0 -1.29483" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.4714 -0.88192 0 1676.58 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="-0.42756 0.903987 0 -0.259153" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.903987 -0.42756 0 81.1564 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="275" owner="0" type="0" pos="39.3442 -56.1899 8" rot="1 0 0 0" scale="" transform="1 0 0 39.3442 0 1 0 -56.1899 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.29677 0.207111 0.5" />
                            <Vertex pos="-1.15163 -0.668991 0.5" />
                            <Vertex pos="1.10546 0.668991 0.5" />
                            <Vertex pos="-1.29678 -0.19051 0.5" />
                            <Vertex pos="1.29677 0.207111 -0.5" />
                            <Vertex pos="-1.15163 -0.668991 -0.5" />
                            <Vertex pos="1.10546 0.668991 -0.5" />
                            <Vertex pos="-1.29678 -0.19051 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 2262.03 0 -1 0 -115.846 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 1129.97 0 -1 0 -115.846 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="0.336907 -0.941538 0 -0.241888" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.941538 -0.336906 0 82.6075 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.923885 0.382671 -0 -1.27732" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.38268 -0.923881 0 1676.48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.956938 -0.290293 -0 -1.29624" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.38268 -0.923881 0 1676.48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="-0.336878 0.941548 0 -0.257482" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.941549 -0.336876 0 81.0389 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="276" owner="0" type="0" pos="36.8824 -56.9356 8" rot="1 0 0 0" scale="" transform="1 0 0 36.8824 0 1 0 -56.9356 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.31016 0.0767021 0.5" />
                            <Vertex pos="-1.21261 -0.555202 0.5" />
                            <Vertex pos="1.16501 0.555206 0.5" />
                            <Vertex pos="-1.31017 -0.0647888 0.5" />
                            <Vertex pos="1.31016 0.0767021 -0.5" />
                            <Vertex pos="-1.21261 -0.555202 -0.5" />
                            <Vertex pos="1.16501 0.555206 -0.5" />
                            <Vertex pos="-1.31017 -0.0647888 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 2104.48 0 -1 0 -68.1211 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 1287.52 0 -1 0 -68.1211 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="0.242974 -0.970033 0 -0.243931" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.970033 -0.242972 0 82.5303 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.956942 0.29028 -0 -1.27601" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.290286 -0.95694 0 1676.36 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.980781 -0.195111 -0 -1.29763" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.290286 -0.95694 0 1676.36 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="-0.242978 0.970032 0 -0.255495" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.970031 -0.24298 0 80.9606 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="277" owner="0" type="0" pos="34.3591 -57.4364 8" rot="1 0 0 0" scale="" transform="1 0 0 34.3591 0 1 0 -57.4364 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.31067 -0.0544014 0.5" />
                            <Vertex pos="-1.26166 -0.436001 0.5" />
                            <Vertex pos="1.21312 0.436005 0.5" />
                            <Vertex pos="-1.31067 0.0616112 0.5" />
                            <Vertex pos="1.31067 -0.0544014 -0.5" />
                            <Vertex pos="-1.26166 -0.436001 -0.5" />
                            <Vertex pos="1.21312 0.436005 -0.5" />
                            <Vertex pos="-1.31067 0.0616112 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 1942.99 0 -1 0 -36.0698 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 1449.01 0 -1 0 -36.0698 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="0.146742 -0.989175 0 -0.246143" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.989175 -0.146742 0 82.4634 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.980784 0.195094 -0 -1.27487" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.195087 -0.980786 0 1676.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.995185 -0.0980162 -0 -1.29832" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.195087 -0.980786 0 1676.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="-0.14674 0.989175 0 -0.253272" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.989175 -0.146743 0 80.894 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="278" owner="0" type="0" pos="31.7987 -57.6874 8" rot="1 0 0 0" scale="" transform="1 0 0 31.7987 0 1 0 -57.6874 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.29879 -0.18499 0.5" />
                            <Vertex pos="-1.29879 -0.312588 0.5" />
                            <Vertex pos="1.24979 0.312592 0.5" />
                            <Vertex pos="-1.29879 0.187393 0.5" />
                            <Vertex pos="1.29879 -0.18499 -0.5" />
                            <Vertex pos="-1.29879 -0.312588 -0.5" />
                            <Vertex pos="1.24979 0.312592 -0.5" />
                            <Vertex pos="-1.29879 0.187393 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 1779.12 0 -1 0 -20.0059 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 1612.88 0 -1 0 -20.0059 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="0.0490627 -0.998796 0 -0.248489" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.998796 -0.0490632 0 82.4417 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.995186 0.0980022 -0 -1.27441" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.0980185 -0.995185 0 1676.07 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-1 -0 -0 -1.29879" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0.0980185 -0.995185 0 1676.07 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="-0.0490658 0.998796 0 -0.250894" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.998795 -0.0490663 0 80.872 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="279" owner="0" type="0" pos="29.2012 -57.6874 8" rot="1 0 0 0" scale="" transform="1 0 0 29.2012 0 1 0 -57.6874 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.29866 -0.312599 0.5" />
                            <Vertex pos="-1.29866 -0.185001 0.5" />
                            <Vertex pos="1.29866 0.187393 0.5" />
                            <Vertex pos="-1.24965 0.312595 0.5" />
                            <Vertex pos="1.29866 -0.312599 -0.5" />
                            <Vertex pos="-1.29866 -0.185001 -0.5" />
                            <Vertex pos="1.29866 0.187393 -0.5" />
                            <Vertex pos="-1.24965 0.312595 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 1612.88 0 -1 0 -20.0059 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 1779.12 0 -1 0 -20.0059 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="-0.0490676 -0.998795 -0 -0.2485" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.998796 0.0490682 0 83.9958 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="1 0 0 -1.29866" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0 -1 0 1675.99 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.995185 0.0980193 0 -1.27427" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 0 -1 0 1675.99 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="0.0490722 0.998795 -0 -0.250895" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.998796 0.0490713 0 82.4256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="280" owner="0" type="0" pos="26.6408 -57.4364 8" rot="1 0 0 0" scale="" transform="1 0 0 26.6408 0 1 0 -57.4364 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.26178 -0.436005 0.5" />
                            <Vertex pos="-1.31079 -0.0544014 0.5" />
                            <Vertex pos="1.31079 0.0616035 0.5" />
                            <Vertex pos="-1.21324 0.436005 0.5" />
                            <Vertex pos="1.26178 -0.436005 -0.5" />
                            <Vertex pos="-1.31079 -0.0544014 -0.5" />
                            <Vertex pos="1.31079 0.0616035 -0.5" />
                            <Vertex pos="-1.21324 0.436005 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 1449.01 0 -1 0 -36.0698 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 1942.99 0 -1 0 -36.0698 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="-0.14673 -0.989177 -0 -0.246145" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.989177 0.146728 0 83.9741 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.995185 -0.0980167 0 -1.29844" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.0980159 -0.995185 0 1676.15 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.980784 0.195094 0 -1.27499" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.0980159 -0.995185 0 1676.15 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="0.146729 0.989177 -0 -0.253268" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.989177 0.146729 0 82.4034 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="281" owner="0" type="0" pos="24.1175 -56.9357 8" rot="1 0 0 0" scale="" transform="1 0 0 24.1175 0 1 0 -56.9357 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.21249 -0.555145 0.5" />
                            <Vertex pos="-1.31004 0.0767593 0.5" />
                            <Vertex pos="1.31004 -0.0647583 0.5" />
                            <Vertex pos="-1.16492 0.555149 0.5" />
                            <Vertex pos="1.21249 -0.555145 -0.5" />
                            <Vertex pos="-1.31004 0.0767593 -0.5" />
                            <Vertex pos="1.31004 -0.0647583 -0.5" />
                            <Vertex pos="-1.16492 0.555149 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 1287.52 0 -1 0 -68.1182 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 2104.48 0 -1 0 -68.1182 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="-0.242996 -0.970027 -0 -0.243876" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.970028 0.242995 0 83.9066 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.980783 -0.195102 0 -1.2975" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.195094 -0.980785 0 1676.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.956939 0.290289 0 -1.27591" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.195094 -0.980785 0 1676.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="0.242966 0.970035 -0 -0.255478" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.970035 0.242965 0 82.3366 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="282" owner="0" type="0" pos="21.6557 -56.1899 8" rot="1 0 0 0" scale="" transform="1 0 0 21.6557 0 1 0 -56.1899 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.15177 -0.669048 0.5" />
                            <Vertex pos="-1.2969 0.207054 0.5" />
                            <Vertex pos="1.2969 -0.190639 0.5" />
                            <Vertex pos="-1.10553 0.669044 0.5" />
                            <Vertex pos="1.15177 -0.669048 -0.5" />
                            <Vertex pos="-1.2969 0.207054 -0.5" />
                            <Vertex pos="1.2969 -0.190639 -0.5" />
                            <Vertex pos="-1.10553 0.669044 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 1129.96 0 -1 0 -115.849 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 2262.04 0 -1 0 -115.849 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="-0.336874 -0.94155 -0 -0.24194" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.94155 0.336874 0 83.8295 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.956937 -0.290296 0 -1.29639" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.290284 -0.95694 0 1676.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.923874 0.382696 0 -1.27741" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.290284 -0.95694 0 1676.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="0.336918 0.941534 -0 -0.257455" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.941535 0.336917 0 82.2604 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="283" owner="0" type="0" pos="19.2791 -55.2064 8" rot="1 0 0 0" scale="" transform="1 0 0 19.2791 0 1 0 -55.2064 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.07971 -0.776405 0.5" />
                            <Vertex pos="-1.27108 0.335484 0.5" />
                            <Vertex pos="1.27108 -0.314423 0.5" />
                            <Vertex pos="-1.0354 0.776405 0.5" />
                            <Vertex pos="1.07971 -0.776405 -0.5" />
                            <Vertex pos="-1.27108 0.335484 -0.5" />
                            <Vertex pos="1.27108 -0.314423 -0.5" />
                            <Vertex pos="-1.0354 0.776405 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 977.862 0 -1 0 -178.791 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 2414.14 0 -1 0 -178.791 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="-0.42757 -0.903982 -0 -0.240204" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.903981 0.427573 0 83.7125 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.923872 -0.382702 0 -1.29465" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.382686 -0.923878 0 1676.54 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.881919 0.471401 0 -1.27914" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.382686 -0.923878 0 1676.54 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="0.427537 0.903998 -0 -0.259196" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.903998 0.427537 0 82.1395 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="284" owner="0" type="0" pos="17.0105 -53.9945 8" rot="1 0 0 0" scale="" transform="1 0 0 17.0105 0 1 0 -53.9945 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.997515 -0.8764 0.5" />
                            <Vertex pos="-1.23319 0.460606 0.5" />
                            <Vertex pos="1.23319 -0.435474 0.5" />
                            <Vertex pos="-0.955366 0.876404 0.5" />
                            <Vertex pos="0.997515 -0.8764 -0.5" />
                            <Vertex pos="-1.23319 0.460606 -0.5" />
                            <Vertex pos="1.23319 -0.435474 -0.5" />
                            <Vertex pos="-0.955366 0.876404 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 832.671 0 -1 0 -256.351 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 2559.33 0 -1 0 -256.351 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="-0.514095 -0.857733 -0 -0.2389" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.857734 0.514094 0 83.5931 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.881925 -0.471389 0 -1.29286" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.471397 -0.881922 0 1676.63 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.831473 0.555566 0 -1.28126" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.471397 -0.881922 0 1676.63 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="0.514134 0.85771 -0 -0.260514" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.85771 0.514134 0 82.0246 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="285" owner="0" type="0" pos="14.8719 -52.5661 8" rot="1 0 0 0" scale="" transform="1 0 0 14.8719 0 1 0 -52.5661 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="217" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.905438 -0.967808 0.5" />
                            <Vertex pos="-1.18326 0.581299 0.5" />
                            <Vertex pos="1.18326 -0.552013 0.5" />
                            <Vertex pos="-0.866066 0.967804 0.5" />
                            <Vertex pos="0.905438 -0.967808 -0.5" />
                            <Vertex pos="-1.18326 0.581299 -0.5" />
                            <Vertex pos="1.18326 -0.552013 -0.5" />
                            <Vertex pos="-0.866066 0.967804 -0.5" />
                        </Vertices>
                        <Face id="210" plane="0 0 1 -0.5" album="PQ" material="pq_wood_2" texgens="1 0 0 695.799 0 -1 0 -347.77 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="211" plane="0 0 -1 -0.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 2696.2 0 -1 0 -347.77 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="212" plane="-0.595705 -0.803203 -0 -0.237973" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.803205 0.595703 0 83.4418 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="213" plane="0.831473 -0.555566 0 -1.29053" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.555573 -0.831468 0 1676.7 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="214" plane="-0.773013 0.63439 0 -1.28345" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.555573 -0.831468 0 1676.7 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="215" plane="0.595682 0.80322 -0 -0.261459" album="PQ" material="pq_wood_2" texgens="0 0 -1 32 -0.80322 0.595682 0 81.87 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="300" owner="0" type="0" pos="61 -29.75 7.75" rot="1 0 0 0" scale="" transform="1 0 0 61 0 1 0 -29.75 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="871" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1.75 0.25" />
                            <Vertex pos="4 1.75 -0.25" />
                            <Vertex pos="4 -1.75 0.25" />
                            <Vertex pos="4 -1.75 -0.25" />
                            <Vertex pos="-4 1.75 0.25" />
                            <Vertex pos="-4 1.75 -0.25" />
                            <Vertex pos="-4 -1.75 0.25" />
                            <Vertex pos="-4 -1.75 -0.25" />
                        </Vertices>
                        <Face id="864" plane="1 -0 0 -4" album="PQ" material="pq_hot_2_med" texgens="0 1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="865" plane="-1 0 0 -4" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="866" plane="0 1 -0 -1.75" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="867" plane="0 -1 0 -1.75" album="PQ" material="pq_hot_2_med" texgens="1 0 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="868" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3904 0 -1 0 1904 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="869" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1952 0 -0.997576 0.0695904 966.951 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="301" owner="0" type="0" pos="61 -25.75 7.75" rot="1 0 0 0" scale="" transform="1 0 0 61 0 1 0 -25.75 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="871" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 11.75 0.25" />
                            <Vertex pos="3 11.75 -0.25" />
                            <Vertex pos="4 -2.25 0.25" />
                            <Vertex pos="4 -2.25 -0.25" />
                            <Vertex pos="-3 11.75 0.25" />
                            <Vertex pos="-3 11.75 -0.25" />
                            <Vertex pos="-4 -2.25 0.25" />
                            <Vertex pos="-4 -2.25 -0.25" />
                        </Vertices>
                        <Face id="864" plane="0.997459 0.071247 0 -3.82953" album="PQ" material="pq_hot_2_med" texgens="0 1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="865" plane="-0.997459 0.071247 0 -3.82953" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="866" plane="0 1 -0 -11.75" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="867" plane="0 -1 0 -2.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 256 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="868" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 3904 0 -1 0 1904 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="869" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 -1952 0 -0.997576 0.0695904 839.261 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="302" owner="0" type="0" pos="56.75 -29.75 7.75" rot="1 0 0 0" scale="" transform="1 0 0 56.75 0 1 0 -29.75 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="259" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.25" />
                            <Vertex pos="0.25 1.75 -0.25" />
                            <Vertex pos="0.25 -1.75 0.75" />
                            <Vertex pos="0.25 -1.75 -0.25" />
                            <Vertex pos="-0.25 1.75 0.25" />
                            <Vertex pos="-0.25 1.75 -0.25" />
                            <Vertex pos="-0.25 -1.75 0.75" />
                            <Vertex pos="-0.25 -1.75 -0.25" />
                        </Vertices>
                        <Face id="252" plane="1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="253" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="254" plane="0 1 -0 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="255" plane="0 -1 0 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="256" plane="-0 0.141421 0.98995 -0.494975" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="257" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="303" owner="0" type="0" pos="65.25 -29.75 7.75" rot="1 0 0 0" scale="" transform="1 0 0 65.25 0 1 0 -29.75 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="259" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.25" />
                            <Vertex pos="0.25 1.75 -0.25" />
                            <Vertex pos="0.25 -1.75 2.75" />
                            <Vertex pos="0.25 -1.75 -0.25" />
                            <Vertex pos="-0.25 1.75 0.25" />
                            <Vertex pos="-0.25 1.75 -0.25" />
                            <Vertex pos="-0.25 -1.75 2.75" />
                            <Vertex pos="-0.25 -1.75 -0.25" />
                        </Vertices>
                        <Face id="252" plane="1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="253" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="254" plane="0 1 -0 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="255" plane="0 -1 0 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="256" plane="-0 0.581238 0.813733 -1.2206" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="257" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="304" owner="0" type="0" pos="56.75 -26.25 7.75" rot="1 0 0 0" scale="" transform="1 0 0 56.75 0 1 0 -26.25 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="259" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 12.25 0.25" />
                            <Vertex pos="1.25 12.25 -0.25" />
                            <Vertex pos="0.25 -1.75 0.25" />
                            <Vertex pos="0.25 -1.75 -0.25" />
                            <Vertex pos="0.75 12.25 0.25" />
                            <Vertex pos="0.75 12.25 -0.25" />
                            <Vertex pos="-0.25 -1.75 0.25" />
                            <Vertex pos="-0.25 -1.75 -0.25" />
                        </Vertices>
                        <Face id="252" plane="0.997459 -0.071247 0 -0.374047" album="PQ" material="pq_wood_2" texgens="0 1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="253" plane="-0.997459 0.071247 0 -0.124682" album="PQ" material="pq_wood_2" texgens="0 -1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="254" plane="0 1 -0 -12.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="255" plane="0 -1 0 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="256" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="257" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="305" owner="0" type="0" pos="65.25 -26.25 7.75" rot="1 0 0 0" scale="" transform="1 0 0 65.25 0 1 0 -26.25 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="259" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 12.25 0.25" />
                            <Vertex pos="-0.75 12.25 -0.25" />
                            <Vertex pos="0.25 -1.75 0.25" />
                            <Vertex pos="0.25 -1.75 -0.25" />
                            <Vertex pos="-1.25 12.25 0.25" />
                            <Vertex pos="-1.25 12.25 -0.25" />
                            <Vertex pos="-0.25 -1.75 0.25" />
                            <Vertex pos="-0.25 -1.75 -0.25" />
                        </Vertices>
                        <Face id="252" plane="0.997459 0.071247 0 -0.124682" album="PQ" material="pq_wood_2" texgens="0 1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="253" plane="-0.997459 -0.071247 0 -0.374047" album="PQ" material="pq_wood_2" texgens="0 -1 0 112 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="254" plane="0 1 -0 -12.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="255" plane="0 -1 0 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="256" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="257" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -112 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="307" owner="0" type="0" pos="-4.25 -29.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 -29.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="559" nextVertexID="745">
                        <Vertices>
                            <Vertex pos="0.25 1.75 -1.25" />
                            <Vertex pos="0.25 1.75 -1.25" />
                            <Vertex pos="0.25 -1.75 1.25" />
                            <Vertex pos="0.25 -1.75 -1.25" />
                            <Vertex pos="-0.25 1.75 -1.25" />
                            <Vertex pos="-0.25 1.75 -1.25" />
                            <Vertex pos="-0.25 -1.75 1.25" />
                            <Vertex pos="-0.25 -1.75 -1.25" />
                        </Vertices>
                        <Face id="552" plane="1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 56 0 0 -1 -40 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="553" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 56 0 0 -1 -40 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="554" plane="0 1 0 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 8 0 0 -1 -40 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="555" plane="0 -1 0 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 8 0 0 -1 -40 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="556" plane="-0 0.581238 0.813733 -0" album="PQ" material="pq_wood_2" texgens="1 0 0 8 0 -1 0 -56 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="557" plane="0 0 -1 -1.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 8 0 -1 0 -56 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="308" owner="0" type="0" pos="4.25 -29.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 -29.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="559" nextVertexID="745">
                        <Vertices>
                            <Vertex pos="0.25 1.75 -1.25" />
                            <Vertex pos="0.25 1.75 -1.25" />
                            <Vertex pos="0.25 -1.75 -0.75" />
                            <Vertex pos="0.25 -1.75 -1.25" />
                            <Vertex pos="-0.25 1.75 -1.25" />
                            <Vertex pos="-0.25 1.75 -1.25" />
                            <Vertex pos="-0.25 -1.75 -0.75" />
                            <Vertex pos="-0.25 -1.75 -1.25" />
                        </Vertices>
                        <Face id="552" plane="1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 56 0 0 -1 -40 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="553" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 56 0 0 -1 -40 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="554" plane="0 1 0 -1.75" album="PQ" material="pq_wood_2" texgens="-1 0 0 8 0 0 -1 -40 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="555" plane="0 -1 0 -1.75" album="PQ" material="pq_wood_2" texgens="1 0 0 8 0 0 -1 -40 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="556" plane="-0 0.141421 0.98995 0.98995" album="PQ" material="pq_wood_2" texgens="1 0 0 8 0 -1 0 -56 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="557" plane="0 0 -1 -1.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 8 0 -1 0 -56 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="381" owner="0" type="0" pos="61 -2.75585 3.40423" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61 0 1 0 -2.75585 1 0 5.96046e-008 3.40423 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.404307 0.755842 3" />
                            <Vertex pos="0.736973 -0.459455 3" />
                            <Vertex pos="-0.904297 0.755842 3" />
                            <Vertex pos="0.350471 -0.776646 3" />
                            <Vertex pos="-0.404308 0.755843 -3" />
                            <Vertex pos="0.736973 -0.459455 -3" />
                            <Vertex pos="-0.904297 0.755843 -3" />
                            <Vertex pos="0.350471 -0.776646 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 -3" album="PQ" material="pq_hot_2_med" texgens="0.707107 -0.707107 0 26.2495 -0.740932 -0.67158 0 7.59953 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_hot_2_med" texgens="0.703167 -0.710858 -0.0154073 24.8153 -0.698598 -0.633209 0.333177 39.1504 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.728957 0.68456 0 -0.222697" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 3904 0.67158 -0.740932 0 318.758 0 0.5 0.41" texRot="0" texScale="0.5 0.41" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-4.76848e-007 1 7.94729e-008 -0.755843" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.707107 0.707107 0 535.102 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.634389 -0.773014 0 -0.822693" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.707107 0.707107 0 535.102 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.773731 -0.633514 -2.51736e-008 -0.220846" album="PQ" material="pq_wood_2" texgens="0 0 1 -1952 0.0695904 -0.997576 0 95.5541 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="382" owner="0" type="0" pos="61 -4.02421 4.44485" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61 0 1 0 -4.02421 1 0 5.96046e-008 4.44485 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.30365 0.808911 3" />
                            <Vertex pos="0.690155 -0.531139 3" />
                            <Vertex pos="-0.690155 0.491714 3" />
                            <Vertex pos="0.274433 -0.808911 3" />
                            <Vertex pos="-0.30365 0.808911 -3" />
                            <Vertex pos="0.690155 -0.531139 -3" />
                            <Vertex pos="-0.690155 0.491714 -3" />
                            <Vertex pos="0.274433 -0.808911 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 -3" album="PQ" material="pq_hot_2_med" texgens="0.634393 -0.773011 0 26.1739 -0.803222 -0.59568 0 7.61443 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_hot_2_med" texgens="0.6301 -0.776361 -0.0154234 24.7382 -0.757329 -0.561646 0.333177 39.1644 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.80322 0.595682 0 -0.237956" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 3904 0.59568 -0.803222 0 437.123 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.634394 0.77301 0 -0.81793" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.773011 0.634393 0 535.091 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.555564 -0.831474 0 -0.825054" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.773011 0.634393 0 535.091 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.803214 -0.595691 0 -0.261432" album="PQ" material="pq_wood_2" texgens="0 0 1 -1952 0.0695904 -0.997576 0 138.361 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="383" owner="0" type="0" pos="61 -5.38865 5.356" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61 0 1 0 -5.38865 1 0 5.96046e-008 5.356 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.220989 0.833305 3" />
                            <Vertex pos="0.636707 -0.597585 3" />
                            <Vertex pos="-0.636707 0.555529 3" />
                            <Vertex pos="0.195713 -0.833306 3" />
                            <Vertex pos="-0.220989 0.833305 -3" />
                            <Vertex pos="0.636707 -0.597585 -3" />
                            <Vertex pos="-0.636707 0.555529 -3" />
                            <Vertex pos="0.195713 -0.833306 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 -3" album="PQ" material="pq_hot_2_med" texgens="0.555568 -0.831471 0 26.1006 -0.857713 -0.514128 0 7.64405 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_hot_2_med" texgens="0.550973 -0.834381 -0.0154062 24.6667 -0.808708 -0.484753 0.333176 39.1922 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.857714 0.514127 0 -0.238879" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 3904 0.514128 -0.857714 0 558.438 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.555574 0.831467 0 -0.815642" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.831471 0.555568 0 535.065 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.471405 -0.881917 0 -0.827167" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.831471 0.555568 0 535.065 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.857733 -0.514096 0 -0.26053" album="PQ" material="pq_wood_2" texgens="0 0 1 -1952 0.0695904 -0.997576 0 183.946 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="384" owner="0" type="0" pos="61 -6.83602 6.12886" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61 0 1 0 -6.83602 1 0 5.96046e-008 6.12886 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.136158 0.849776 3" />
                            <Vertex pos="0.577145 -0.658419 3" />
                            <Vertex pos="-0.577145 0.614064 3" />
                            <Vertex pos="0.115158 -0.849777 3" />
                            <Vertex pos="-0.136158 0.849776 -3" />
                            <Vertex pos="0.577145 -0.658419 -3" />
                            <Vertex pos="-0.577145 0.614064 -3" />
                            <Vertex pos="0.115158 -0.849777 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 -3" album="PQ" material="pq_hot_2_med" texgens="0.471396 -0.881921 0 26.036 -0.903995 -0.427543 0 7.6875 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_hot_2_med" texgens="0.466534 -0.884369 -0.0154201 24.601 -0.852345 -0.403115 0.333177 39.2332 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.903994 0.427545 0 -0.240232" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 3904 0.427543 -0.903995 0 540.805 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.471396 0.881921 0 -0.81362" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.881921 0.471397 0 535.025 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.382679 -0.923881 0 -0.829162" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.881921 0.471397 0 535.025 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.904 -0.427534 0 -0.259205" album="PQ" material="pq_wood_2" texgens="0 0 1 -1952 0.0695904 -0.997576 0 231.871 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="385" owner="0" type="0" pos="61 -8.35236 6.75601" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61 0 1 0 -8.35236 1 0 5.96046e-008 6.75601 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.0499992 0.857927 3" />
                            <Vertex pos="0.512001 -0.712774 3" />
                            <Vertex pos="-0.512001 0.666563 3" />
                            <Vertex pos="0.033493 -0.857927 3" />
                            <Vertex pos="-0.0499992 0.857927 -3" />
                            <Vertex pos="0.512001 -0.712774 -3" />
                            <Vertex pos="-0.512001 0.666563 -3" />
                            <Vertex pos="0.033493 -0.857927 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 -3" album="PQ" material="pq_hot_2_med" texgens="0.38268 -0.923881 0 25.9762 -0.941545 -0.336887 0 7.74203 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_hot_2_med" texgens="0.377602 -0.92584 -0.015416 24.5419 -0.887749 -0.317638 0.333177 39.2847 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.941545 0.336887 0 -0.241948" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 3904 0.336887 -0.941545 0 648.969 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.382678 0.923882 0 -0.811757" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.923881 0.382679 0 534.973 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.290283 -0.956941 0 -0.830708" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.923881 0.382679 0 534.973 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.94154 -0.336902 0 -0.257503" album="PQ" material="pq_wood_2" texgens="0 0 1 -1952 0.0695904 -0.997576 0 281.673 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="386" owner="0" type="0" pos="61 -9.92311 7.23146" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61 0 1 0 -9.92311 1 0 5.96046e-008 7.23146 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.036541 0.85797 3" />
                            <Vertex pos="0.441944 -0.760428 3" />
                            <Vertex pos="-0.441944 0.712824 3" />
                            <Vertex pos="-0.048439 -0.85797 3" />
                            <Vertex pos="0.036541 0.85797 -3" />
                            <Vertex pos="0.441944 -0.760428 -3" />
                            <Vertex pos="-0.441944 0.712824 -3" />
                            <Vertex pos="-0.048439 -0.85797 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 -3" album="PQ" material="pq_hot_2_med" texgens="0.290286 -0.95694 0 25.9334 -0.970029 -0.242988 0 7.80565 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_hot_2_med" texgens="0.285041 -0.958391 -0.0154142 24.4996 -0.914606 -0.229104 0.333177 39.3446 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.970029 0.242989 0 -0.243923" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 3904 0.242988 -0.970029 0 754.103 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.290282 0.956941 0 -0.810419" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.95694 0.290286 0 534.912 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.195087 -0.980786 0 -0.832035" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.95694 0.290286 0 534.912 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.970025 -0.243004 0 -0.255478" album="PQ" material="pq_wood_2" texgens="0 0 1 -1952 0.0695904 -0.997576 0 332.873 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="387" owner="0" type="0" pos="61 -11.5331 7.55056" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61 0 1 0 -11.5331 1 0 5.96046e-008 7.55056 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.122845 0.849584 3" />
                            <Vertex pos="0.367542 -0.800575 3" />
                            <Vertex pos="-0.367542 0.752043 3" />
                            <Vertex pos="-0.130051 -0.849584 3" />
                            <Vertex pos="0.122845 0.849584 -3" />
                            <Vertex pos="0.367542 -0.800575 -3" />
                            <Vertex pos="-0.367542 0.752043 -3" />
                            <Vertex pos="-0.130051 -0.849584 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 -3" album="PQ" material="pq_hot_2_med" texgens="0.195085 -0.980786 0 25.8974 -0.989183 -0.146684 0 7.87645 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_hot_2_med" texgens="0.189718 -0.981717 -0.0154295 24.4626 -0.932666 -0.138303 0.333177 39.4114 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.989183 0.146683 0 -0.246136" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 3904 0.0980057 -0.995186 0 737.127 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.195085 0.980786 0 -0.809295" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.980786 0.195085 0 534.842 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.0980176 -0.995185 0 -0.832746" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.980786 0.195085 0 534.842 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.989184 -0.146678 0 -0.253259" album="PQ" material="pq_wood_2" texgens="0 0 1 -1952 0.0695904 -0.997576 0 384.98 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="388" owner="0" type="0" pos="61 -13.1669 7.71025" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61 0 1 0 -13.1669 1 0 5.96046e-008 7.71025 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.207848 0.83315 3" />
                            <Vertex pos="0.289745 -0.83315 3" />
                            <Vertex pos="-0.289742 0.784142 3" />
                            <Vertex pos="-0.210243 -0.83315 3" />
                            <Vertex pos="0.207848 0.83315 -3" />
                            <Vertex pos="0.289745 -0.83315 -3" />
                            <Vertex pos="-0.289742 0.784142 -3" />
                            <Vertex pos="-0.210243 -0.83315 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 -3" album="PQ" material="pq_hot_2_med" texgens="0.0980179 -0.995185 0 25.8805 -0.998794 -0.0490913 0 7.95202 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="0 0 -1 -3" album="PQ" material="pq_hot_2_med" texgens="0.0925924 -0.995585 -0.0154091 24.448 -0.941727 -0.0462864 0.333178 39.4828 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.998794 0.0490902 0 -0.248496" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 3904 0.0980057 -0.995186 0 842.183 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.0980174 0.995185 0 -0.808765" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.995185 0.0980179 0 534.766 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0 -1 0 -0.83315" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 96 0.995185 0.0980179 0 534.766 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.998794 -0.0490959 0 -0.250894" album="PQ" material="pq_wood_2" texgens="0 0 1 -1952 0.0695904 -0.997576 0 437.488 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="396" owner="0" type="0" pos="61.5 -2.75585 3.40423" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61.5 0 1 0 -2.75585 1 0 5.96046e-008 3.40423 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.404307 0.755842 -2.5" />
                            <Vertex pos="0.736973 -0.459455 -2.5" />
                            <Vertex pos="-0.904297 0.755842 -2.5" />
                            <Vertex pos="0.350472 -0.776646 -2.5" />
                            <Vertex pos="-0.404308 0.755843 -3" />
                            <Vertex pos="0.736973 -0.459455 -3" />
                            <Vertex pos="-0.904297 0.755843 -3" />
                            <Vertex pos="0.350471 -0.776646 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.707107 -0.707107 0 26.2495 -0.740932 -0.67158 0 7.59953 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.703167 -0.710858 -0.0154073 24.8153 -0.698598 -0.633209 0.333177 39.1504 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.728957 0.68456 -3.47594e-007 -0.222698" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.67158 -0.740932 0 318.758 0 0.5 0.41" texRot="0" texScale="0.5 0.41" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-4.76848e-007 1 9.53675e-007 -0.75584" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.707107 0.707107 0 535.102 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.63439 -0.773013 -6.05001e-007 -0.822695" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.707107 0.707107 0 535.102 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.773731 -0.633514 4.35804e-007 -0.220844" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.671577 -0.740934 0 25.8673 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="397" owner="0" type="0" pos="61.5 -4.02421 4.44485" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61.5 0 1 0 -4.02421 1 0 5.96046e-008 4.44485 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.30365 0.808911 -2.5" />
                            <Vertex pos="0.690155 -0.531139 -2.5" />
                            <Vertex pos="-0.690155 0.491714 -2.5" />
                            <Vertex pos="0.274433 -0.808911 -2.5" />
                            <Vertex pos="-0.30365 0.808911 -3" />
                            <Vertex pos="0.690155 -0.531139 -3" />
                            <Vertex pos="-0.690155 0.491714 -3" />
                            <Vertex pos="0.274433 -0.808911 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.634393 -0.773011 0 26.1739 -0.803222 -0.59568 0 7.61443 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.6301 -0.776361 -0.0154234 24.7382 -0.757329 -0.561646 0.333177 39.1644 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.80322 0.595682 0 -0.237956" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.59568 -0.803222 0 437.123 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.634394 0.77301 0 -0.81793" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.773011 0.634393 0 535.091 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.555564 -0.831474 0 -0.825054" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.773011 0.634393 0 535.091 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.803214 -0.595691 3.83002e-007 -0.261431" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.595692 -0.803213 0 25.7942 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="398" owner="0" type="0" pos="61.5 -5.38865 5.356" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61.5 0 1 0 -5.38865 1 0 5.96046e-008 5.356 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.220989 0.833305 -2.5" />
                            <Vertex pos="0.636707 -0.597585 -2.5" />
                            <Vertex pos="-0.636707 0.555529 -2.5" />
                            <Vertex pos="0.195713 -0.833306 -2.5" />
                            <Vertex pos="-0.220989 0.833305 -3" />
                            <Vertex pos="0.636707 -0.597585 -3" />
                            <Vertex pos="-0.636707 0.555529 -3" />
                            <Vertex pos="0.195713 -0.833306 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.555568 -0.831471 0 26.1006 -0.857713 -0.514128 0 7.64405 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.550973 -0.834381 -0.0154062 24.6667 -0.808708 -0.484753 0.333176 39.1922 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.857714 0.514127 0 -0.238879" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.514128 -0.857714 0 558.438 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.555574 0.831467 0 -0.815642" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.831471 0.555568 0 535.065 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.471405 -0.881917 0 -0.827167" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.831471 0.555568 0 535.065 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.857733 -0.514096 0 -0.26053" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.514096 -0.857733 0 25.7217 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="399" owner="0" type="0" pos="61.5 -6.83602 6.12886" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61.5 0 1 0 -6.83602 1 0 5.96046e-008 6.12886 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.136158 0.849776 -2.5" />
                            <Vertex pos="0.577145 -0.658419 -2.5" />
                            <Vertex pos="-0.577145 0.614064 -2.5" />
                            <Vertex pos="0.115158 -0.849777 -2.5" />
                            <Vertex pos="-0.136158 0.849776 -3" />
                            <Vertex pos="0.577145 -0.658419 -3" />
                            <Vertex pos="-0.577145 0.614064 -3" />
                            <Vertex pos="0.115158 -0.849777 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.471396 -0.881921 0 26.036 -0.903995 -0.427543 0 7.6875 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.466534 -0.884369 -0.0154201 24.601 -0.852345 -0.403115 0.333177 39.2332 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.903994 0.427545 0 -0.240232" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.427543 -0.903995 0 540.805 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.471396 0.881921 0 -0.81362" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.881921 0.471397 0 535.025 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.382679 -0.923881 0 -0.829162" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.881921 0.471397 0 535.025 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.904 -0.427534 0 -0.259205" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.427533 -0.904 0 25.6603 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="400" owner="0" type="0" pos="61.5 -8.35236 6.75601" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61.5 0 1 0 -8.35236 1 0 5.96046e-008 6.75601 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.0499992 0.857927 -2.5" />
                            <Vertex pos="0.512001 -0.712774 -2.5" />
                            <Vertex pos="-0.512001 0.666563 -2.5" />
                            <Vertex pos="0.033493 -0.857927 -2.5" />
                            <Vertex pos="-0.0499992 0.857927 -3" />
                            <Vertex pos="0.512001 -0.712774 -3" />
                            <Vertex pos="-0.512001 0.666563 -3" />
                            <Vertex pos="0.033493 -0.857927 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.38268 -0.923881 0 25.9762 -0.941545 -0.336887 0 7.74203 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.377602 -0.92584 -0.015416 24.5419 -0.887749 -0.317638 0.333177 39.2847 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.941545 0.336887 0 -0.241948" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.336887 -0.941545 0 648.969 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.382678 0.923882 0 -0.811757" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.923881 0.382679 0 534.973 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.290283 -0.956941 0 -0.830708" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.923881 0.382679 0 534.973 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.94154 -0.336902 0 -0.257503" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.336904 -0.941539 0 25.6036 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="401" owner="0" type="0" pos="61.5 -9.92311 7.23146" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61.5 0 1 0 -9.92311 1 0 5.96046e-008 7.23146 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.036541 0.85797 -2.5" />
                            <Vertex pos="0.441944 -0.760428 -2.5" />
                            <Vertex pos="-0.441944 0.712825 -2.5" />
                            <Vertex pos="-0.048439 -0.85797 -2.5" />
                            <Vertex pos="0.036541 0.85797 -3" />
                            <Vertex pos="0.441944 -0.760428 -3" />
                            <Vertex pos="-0.441944 0.712824 -3" />
                            <Vertex pos="-0.048439 -0.85797 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.290286 -0.95694 0 25.9334 -0.970029 -0.242988 0 7.80565 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.285041 -0.958391 -0.0154142 24.4996 -0.914606 -0.229104 0.333177 39.3446 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.970029 0.242989 0 -0.243923" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.242988 -0.970029 0 754.103 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.290282 0.956941 -9.1261e-007 -0.810422" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.95694 0.290286 0 534.912 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.195088 -0.980786 -9.3535e-007 -0.832038" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.95694 0.290286 0 534.912 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.970025 -0.243004 2.31747e-007 -0.255477" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.243 -0.970026 0 25.5636 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="402" owner="0" type="0" pos="61.5 -11.5331 7.55056" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61.5 0 1 0 -11.5331 1 0 5.96046e-008 7.55056 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.122845 0.849585 -2.5" />
                            <Vertex pos="0.367542 -0.800575 -2.5" />
                            <Vertex pos="-0.367542 0.752043 -2.5" />
                            <Vertex pos="-0.130051 -0.849585 -2.5" />
                            <Vertex pos="0.122845 0.849584 -3" />
                            <Vertex pos="0.367542 -0.800575 -3" />
                            <Vertex pos="-0.367542 0.752043 -3" />
                            <Vertex pos="-0.130051 -0.849584 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.195085 -0.980786 0 25.8974 -0.989183 -0.146684 0 7.87645 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.189718 -0.981717 -0.0154295 24.4626 -0.932666 -0.138303 0.333177 39.4114 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.989183 0.146683 0 -0.246136" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.0980057 -0.995186 0 737.127 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.195085 0.980786 -9.35351e-007 -0.809298" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.980786 0.195085 0 534.842 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.0980185 -0.995185 -9.49082e-007 -0.832749" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.980786 0.195085 0 534.842 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.989184 -0.146678 0 -0.253259" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.146682 -0.989184 0 25.5304 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="403" owner="0" type="0" pos="61.5 -13.1669 7.71025" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 61.5 0 1 0 -13.1669 1 0 5.96046e-008 7.71025 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.207848 0.83315 -2.5" />
                            <Vertex pos="0.289745 -0.83315 -2.5" />
                            <Vertex pos="-0.289742 0.784142 -2.5" />
                            <Vertex pos="-0.210243 -0.83315 -2.5" />
                            <Vertex pos="0.207848 0.83315 -3" />
                            <Vertex pos="0.289745 -0.83315 -3" />
                            <Vertex pos="-0.289742 0.784142 -3" />
                            <Vertex pos="-0.210243 -0.83315 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.0980179 -0.995185 0 25.8805 -0.998794 -0.0490913 0 7.95202 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.0925924 -0.995585 -0.0154091 24.448 -0.941727 -0.0462864 0.333178 39.4828 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.998794 0.0490899 9.52525e-007 -0.248494" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.0980057 -0.995186 0 842.183 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.0980174 0.995185 0 -0.808765" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.995185 0.0980179 0 534.766 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0 -1 0 -0.83315" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.995185 0.0980179 0 534.766 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.998794 -0.0490959 0 -0.250894" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.0490972 -0.998794 0 25.5175 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="404" owner="0" type="0" pos="55 -2.75585 3.40423" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 55 0 1 0 -2.75585 1 0 5.96046e-008 3.40423 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.404308 0.755842 -2.5" />
                            <Vertex pos="0.736973 -0.459455 -2.5" />
                            <Vertex pos="-0.904298 0.755842 -2.5" />
                            <Vertex pos="0.350472 -0.776646 -2.5" />
                            <Vertex pos="-0.404308 0.755843 -3" />
                            <Vertex pos="0.736973 -0.459455 -3" />
                            <Vertex pos="-0.904297 0.755843 -3" />
                            <Vertex pos="0.350471 -0.776646 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.707107 -0.707107 0 26.2495 -0.740932 -0.67158 0 7.59953 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.703167 -0.710858 -0.0154073 24.8153 -0.698598 -0.633209 0.333177 39.1504 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.728956 0.68456 -3.47594e-007 -0.222697" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.67158 -0.740932 0 318.758 0 0.5 0.41" texRot="0" texScale="0.5 0.41" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-4.76848e-007 1 9.53675e-007 -0.75584" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.707107 0.707107 0 535.102 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.63439 -0.773013 -6.05001e-007 -0.822695" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.707107 0.707107 0 535.102 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.773731 -0.633514 -6.71027e-007 -0.220848" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.671577 -0.740934 0 25.8673 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="405" owner="0" type="0" pos="55 -4.02421 4.44485" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 55 0 1 0 -4.02421 1 0 5.96046e-008 4.44485 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.30365 0.808911 -2.5" />
                            <Vertex pos="0.690155 -0.531139 -2.5" />
                            <Vertex pos="-0.690155 0.491714 -2.5" />
                            <Vertex pos="0.274433 -0.808911 -2.5" />
                            <Vertex pos="-0.30365 0.808911 -3" />
                            <Vertex pos="0.690155 -0.531139 -3" />
                            <Vertex pos="-0.690155 0.491714 -3" />
                            <Vertex pos="0.274433 -0.808911 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.634393 -0.773011 0 26.1739 -0.803222 -0.59568 0 7.61443 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.6301 -0.776361 -0.0154234 24.7382 -0.757329 -0.561646 0.333177 39.1644 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.80322 0.595682 0 -0.237956" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.59568 -0.803222 0 437.123 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.634394 0.77301 0 -0.81793" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.773011 0.634393 0 535.091 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.555564 -0.831474 0 -0.825054" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.773011 0.634393 0 535.091 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.803214 -0.595691 3.83002e-007 -0.261431" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.595692 -0.803213 0 25.7942 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="406" owner="0" type="0" pos="55 -5.38865 5.356" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 55 0 1 0 -5.38865 1 0 5.96046e-008 5.356 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.220989 0.833305 -2.5" />
                            <Vertex pos="0.636707 -0.597585 -2.5" />
                            <Vertex pos="-0.636707 0.555529 -2.5" />
                            <Vertex pos="0.195713 -0.833306 -2.5" />
                            <Vertex pos="-0.220989 0.833305 -3" />
                            <Vertex pos="0.636707 -0.597585 -3" />
                            <Vertex pos="-0.636707 0.555529 -3" />
                            <Vertex pos="0.195713 -0.833306 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.555568 -0.831471 0 26.1006 -0.857713 -0.514128 0 7.64405 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.550973 -0.834381 -0.0154062 24.6667 -0.808708 -0.484753 0.333176 39.1922 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.857714 0.514127 0 -0.238879" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.514128 -0.857714 0 558.438 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.555574 0.831467 0 -0.815642" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.831471 0.555568 0 535.065 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.471405 -0.881917 0 -0.827167" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.831471 0.555568 0 535.065 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.857733 -0.514096 0 -0.26053" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.514096 -0.857733 0 25.7217 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="407" owner="0" type="0" pos="55 -6.83602 6.12886" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 55 0 1 0 -6.83602 1 0 5.96046e-008 6.12886 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.136158 0.849776 -2.5" />
                            <Vertex pos="0.577145 -0.658419 -2.5" />
                            <Vertex pos="-0.577145 0.614064 -2.5" />
                            <Vertex pos="0.115158 -0.849777 -2.5" />
                            <Vertex pos="-0.136158 0.849776 -3" />
                            <Vertex pos="0.577145 -0.658419 -3" />
                            <Vertex pos="-0.577145 0.614064 -3" />
                            <Vertex pos="0.115158 -0.849777 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.471396 -0.881921 0 26.036 -0.903995 -0.427543 0 7.6875 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.466534 -0.884369 -0.0154201 24.601 -0.852345 -0.403115 0.333177 39.2332 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.903994 0.427545 0 -0.240232" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.427543 -0.903995 0 540.805 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.471396 0.881921 0 -0.81362" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.881921 0.471397 0 535.025 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.382679 -0.923881 0 -0.829162" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.881921 0.471397 0 535.025 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.904 -0.427534 0 -0.259205" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.427533 -0.904 0 25.6603 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="408" owner="0" type="0" pos="55 -8.35236 6.75601" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 55 0 1 0 -8.35236 1 0 5.96046e-008 6.75601 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="-0.0499992 0.857927 -2.5" />
                            <Vertex pos="0.512001 -0.712774 -2.5" />
                            <Vertex pos="-0.512001 0.666563 -2.5" />
                            <Vertex pos="0.033493 -0.857927 -2.5" />
                            <Vertex pos="-0.0499992 0.857927 -3" />
                            <Vertex pos="0.512001 -0.712774 -3" />
                            <Vertex pos="-0.512001 0.666563 -3" />
                            <Vertex pos="0.033493 -0.857927 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.38268 -0.923881 0 25.9762 -0.941545 -0.336887 0 7.74203 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.377602 -0.92584 -0.015416 24.5419 -0.887749 -0.317638 0.333177 39.2847 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.941545 0.336887 0 -0.241948" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.336887 -0.941545 0 648.969 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.382678 0.923882 0 -0.811757" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.923881 0.382679 0 534.973 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.290283 -0.956941 0 -0.830708" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.923881 0.382679 0 534.973 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.94154 -0.336902 0 -0.257503" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.336904 -0.941539 0 25.6036 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="409" owner="0" type="0" pos="55 -9.92311 7.23146" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 55 0 1 0 -9.92311 1 0 5.96046e-008 7.23146 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.036541 0.85797 -2.5" />
                            <Vertex pos="0.441944 -0.760428 -2.5" />
                            <Vertex pos="-0.441944 0.712825 -2.5" />
                            <Vertex pos="-0.048439 -0.85797 -2.5" />
                            <Vertex pos="0.036541 0.85797 -3" />
                            <Vertex pos="0.441944 -0.760428 -3" />
                            <Vertex pos="-0.441944 0.712824 -3" />
                            <Vertex pos="-0.048439 -0.85797 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.290286 -0.95694 0 25.9334 -0.970029 -0.242988 0 7.80565 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.285041 -0.958391 -0.0154142 24.4996 -0.914606 -0.229104 0.333177 39.3446 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.970029 0.242989 0 -0.243923" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.242988 -0.970029 0 754.103 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.290282 0.956941 -9.1261e-007 -0.810422" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.95694 0.290286 0 534.912 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.195088 -0.980786 -9.3535e-007 -0.832038" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.95694 0.290286 0 534.912 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.970025 -0.243004 2.31747e-007 -0.255477" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.243 -0.970026 0 25.5636 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="410" owner="0" type="0" pos="55 -11.5331 7.55056" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 55 0 1 0 -11.5331 1 0 5.96046e-008 7.55056 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.122845 0.849585 -2.5" />
                            <Vertex pos="0.367542 -0.800575 -2.5" />
                            <Vertex pos="-0.367542 0.752043 -2.5" />
                            <Vertex pos="-0.130051 -0.849585 -2.5" />
                            <Vertex pos="0.122845 0.849584 -3" />
                            <Vertex pos="0.367542 -0.800575 -3" />
                            <Vertex pos="-0.367542 0.752043 -3" />
                            <Vertex pos="-0.130051 -0.849584 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.195085 -0.980786 0 25.8974 -0.989183 -0.146684 0 7.87645 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="-0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.189718 -0.981717 -0.0154295 24.4626 -0.932666 -0.138303 0.333177 39.4114 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.989183 0.146683 0 -0.246136" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.0980057 -0.995186 0 737.127 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.195085 0.980786 -9.35351e-007 -0.809298" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.980786 0.195085 0 534.842 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0.0980185 -0.995185 -9.49082e-007 -0.832749" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.980786 0.195085 0 534.842 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.989184 -0.146678 0 -0.253259" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.146682 -0.989184 0 25.5304 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="411" owner="0" type="0" pos="55 -13.1669 7.71025" rot="0 -1 0 4.71239" scale="" transform="5.96046e-008 0 -1 55 0 1 0 -13.1669 1 0 5.96046e-008 7.71025 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="25">
                        <Vertices>
                            <Vertex pos="0.207848 0.83315 -2.5" />
                            <Vertex pos="0.289745 -0.83315 -2.5" />
                            <Vertex pos="-0.289742 0.784142 -2.5" />
                            <Vertex pos="-0.210243 -0.83315 -2.5" />
                            <Vertex pos="0.207848 0.83315 -3" />
                            <Vertex pos="0.289745 -0.83315 -3" />
                            <Vertex pos="-0.289742 0.784142 -3" />
                            <Vertex pos="-0.210243 -0.83315 -3" />
                        </Vertices>
                        <Face id="12" plane="-0 0 1 2.5" album="PQ" material="pq_wood_2" texgens="0.0980179 -0.995185 0 25.8805 -0.998794 -0.0490913 0 7.95202 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="13" plane="0 0 -1 -3" album="PQ" material="pq_wood_2" texgens="0.0925924 -0.995585 -0.0154091 24.448 -0.941727 -0.0462864 0.333178 39.4828 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="14" plane="0.998794 0.0490899 9.52525e-007 -0.248494" album="PQ" material="pq_wood_2" texgens="0 0 -1 3904 0.0980057 -0.995186 0 842.183 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0.0980174 0.995185 0 -0.808765" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.995185 0.0980179 0 534.766 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="16" plane="0 -1 0 -0.83315" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.995185 0.0980179 0 534.766 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="17" plane="-0.998794 -0.0490959 0 -0.250894" album="PQ" material="pq_wood_2" texgens="0 0 -1 96 0.0490972 -0.998794 0 25.5175 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="412" owner="0" type="0" pos="61 19 2.75" rot="1 0 0 0" scale="" transform="1 0 0 61 0 1 0 19 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="2695" nextVertexID="3577">
                        <Vertices>
                            <Vertex pos="3 21 -36.75" />
                            <Vertex pos="3 21 -37.25" />
                            <Vertex pos="3 -21 0.25" />
                            <Vertex pos="3 -21 -0.25" />
                            <Vertex pos="-3 21 -36.75" />
                            <Vertex pos="-3 21 -37.25" />
                            <Vertex pos="-3 -21 0.25" />
                            <Vertex pos="-3 -21 -0.25" />
                        </Vertices>
                        <Face id="2688" plane="1 0 0 -3" album="PQ" material="pq_hot_2_med" texgens="0 1 0 1344 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2689" plane="-1 0 0 -3" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 1344 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2690" plane="0 1 -0 -21" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2691" plane="0 -1 0 -21" album="PQ" material="pq_hot_2_med" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2692" plane="-0 0.661031 0.750359 13.6941" album="PQ" material="pq_hot_2_med" texgens="1 0 0 192 0 -1 0 -1606.01 0 0.5 0.4214" texRot="0" texScale="0.5 0.4214" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2693" plane="-0 -0.661031 -0.750359 -14.0692" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 -1 0 -1344 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="413" owner="0" type="0" pos="62 19 2.75" rot="1 0 0 0" scale="" transform="1 0 0 62 0 1 0 19 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="2695" nextVertexID="3577">
                        <Vertices>
                            <Vertex pos="2.5 21 -36.75" />
                            <Vertex pos="2.5 21 -37.25" />
                            <Vertex pos="2.5 -21 0.25" />
                            <Vertex pos="2.5 -21 -0.25" />
                            <Vertex pos="2 21 -36.75" />
                            <Vertex pos="2 21 -37.25" />
                            <Vertex pos="2 -21 0.25" />
                            <Vertex pos="2 -21 -0.25" />
                        </Vertices>
                        <Face id="2688" plane="1 0 0 -2.5" album="PQ" material="pq_wood_2" texgens="0 1 0 1344 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2689" plane="-1 0 0 2" album="PQ" material="pq_wood_2" texgens="0 -1 0 1344 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2690" plane="0 1 -0 -21" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2691" plane="0 -1 0 -21" album="PQ" material="pq_wood_2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2692" plane="-0 0.661031 0.750359 13.694" album="PQ" material="pq_wood_2" texgens="1 0 0 192 0 -1 0 -1606.01 0 0.5 0.4214" texRot="0" texScale="0.5 0.4214" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2693" plane="-0 -0.661031 -0.750359 -14.0692" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 -1 0 -1344 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="414" owner="0" type="0" pos="55.5 19 2.75" rot="1 0 0 0" scale="" transform="1 0 0 55.5 0 1 0 19 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="2695" nextVertexID="3577">
                        <Vertices>
                            <Vertex pos="2.5 21 -36.75" />
                            <Vertex pos="2.5 21 -37.25" />
                            <Vertex pos="2.5 -21 0.25" />
                            <Vertex pos="2.5 -21 -0.25" />
                            <Vertex pos="2 21 -36.75" />
                            <Vertex pos="2 21 -37.25" />
                            <Vertex pos="2 -21 0.25" />
                            <Vertex pos="2 -21 -0.25" />
                        </Vertices>
                        <Face id="2688" plane="1 0 0 -2.5" album="PQ" material="pq_wood_2" texgens="0 1 0 1344 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2689" plane="-1 0 0 2" album="PQ" material="pq_wood_2" texgens="0 -1 0 1344 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2690" plane="0 1 -0 -21" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2691" plane="0 -1 0 -21" album="PQ" material="pq_wood_2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2692" plane="-0 0.661031 0.750359 13.694" album="PQ" material="pq_wood_2" texgens="1 0 0 192 0 -1 0 -1606.01 0 0.5 0.4214" texRot="0" texScale="0.5 0.4214" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2693" plane="-0 -0.661031 -0.750359 -14.0692" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 -1 0 -1344 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="415" owner="0" type="0" pos="61 43 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 61 0 1 0 43 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1975" nextVertexID="2633">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="1968" plane="1 -0 0 -3" album="PQ" material="pq_friction_bouncy" texgens="0 1 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1969" plane="-1 0 0 -3" album="PQ" material="pq_friction_bouncy" texgens="0 -1 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1970" plane="0 1 -0 -3" album="PQ" material="pq_friction_bouncy" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1971" plane="0 -1 0 -3" album="PQ" material="pq_friction_bouncy" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1972" plane="-0 0 1 -0.25" album="PQ" material="pq_friction_bouncy" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1973" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="416" owner="0" type="0" pos="64.25 43.25 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 64.25 0 1 0 43.25 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="451" nextVertexID="601">
                        <Vertices>
                            <Vertex pos="0.25 2.75 0.25" />
                            <Vertex pos="0.25 2.75 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 -3.25 -0.25" />
                        </Vertices>
                        <Face id="444" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 208 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="445" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 208 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="446" plane="0.707107 0.707107 -0 -2.12132" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="447" plane="0 -1 0 -3.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="448" plane="0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -208 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="449" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -208 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="417" owner="0" type="0" pos="57.75 43.25 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 57.75 0 1 0 43.25 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="451" nextVertexID="601">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 2.75 0.25" />
                            <Vertex pos="-0.25 2.75 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 -3.25 -0.25" />
                        </Vertices>
                        <Face id="444" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 208 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="445" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 208 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="446" plane="-0.707107 0.707107 0 -2.12132" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="447" plane="0 -1 0 -3.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="448" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -208 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="449" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -208 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="418" owner="0" type="0" pos="61 46.25 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 61 0 1 0 46.25 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="355" nextVertexID="473">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="348" plane="1 -0 0 -3" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="349" plane="-1 0 0 -3" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="350" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="351" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="352" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 192 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="353" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="419" owner="0" type="0" pos="61 67 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 61 0 1 0 67 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="3189" nextVertexID="4225">
                        <Vertices>
                            <Vertex pos="3 11 0.25" />
                            <Vertex pos="3 11 -0.25" />
                            <Vertex pos="3 -11 0.25" />
                            <Vertex pos="3 -11 -0.25" />
                            <Vertex pos="-3 11 0.25" />
                            <Vertex pos="-3 11 -0.25" />
                            <Vertex pos="-3 -11 0.25" />
                            <Vertex pos="-3 -11 -0.25" />
                        </Vertices>
                        <Face id="3182" plane="1 -0 0 -3" album="PQ" material="pq_hot_2_med" texgens="0 1 0 704 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="3183" plane="-1 0 0 -3" album="PQ" material="pq_hot_2_med" texgens="0 -1 0 704 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="3184" plane="0 1 -0 -11" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3185" plane="0 -1 0 -11" album="PQ" material="pq_hot_2_med" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3186" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 192 0 -1 0 -704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3187" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="-1 0 0 192 0 -1 0 -704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="421" owner="0" type="0" pos="61 55.75 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 61 0 1 0 55.75 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="373" nextVertexID="497">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="366" plane="1 -0 0 -3" album="PQ" material="pq_wood_2" texgens="0 1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="367" plane="-1 0 0 -3" album="PQ" material="pq_wood_2" texgens="0 -1 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="368" plane="0 1 -0 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="369" plane="0 -1 0 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="370" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 192 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="371" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 192 0 -1 0 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="422" owner="0" type="0" pos="57.75 67 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 57.75 0 1 0 67 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="433" nextVertexID="577">
                        <Vertices>
                            <Vertex pos="0.25 11.5 0.25" />
                            <Vertex pos="0.25 11.5 -0.25" />
                            <Vertex pos="0.25 -11.5 0.25" />
                            <Vertex pos="0.25 -11.5 -0.25" />
                            <Vertex pos="-0.25 11.5 0.25" />
                            <Vertex pos="-0.25 11.5 -0.25" />
                            <Vertex pos="-0.25 -11.5 0.25" />
                            <Vertex pos="-0.25 -11.5 -0.25" />
                        </Vertices>
                        <Face id="426" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 736 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="427" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 736 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="428" plane="0 1 -0 -11.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="429" plane="0 -1 0 -11.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="430" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -736 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="431" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -736 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="423" owner="0" type="0" pos="64.25 67 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 64.25 0 1 0 67 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="433" nextVertexID="577">
                        <Vertices>
                            <Vertex pos="0.25 11.5 0.25" />
                            <Vertex pos="0.25 11.5 -0.25" />
                            <Vertex pos="0.25 -11.5 0.25" />
                            <Vertex pos="0.25 -11.5 -0.25" />
                            <Vertex pos="-0.25 11.5 0.25" />
                            <Vertex pos="-0.25 11.5 -0.25" />
                            <Vertex pos="-0.25 -11.5 0.25" />
                            <Vertex pos="-0.25 -11.5 -0.25" />
                        </Vertices>
                        <Face id="426" plane="1 -0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 1 0 736 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="427" plane="-1 0 0 -0.25" album="PQ" material="pq_wood_2" texgens="0 -1 0 736 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="428" plane="0 1 -0 -11.5" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="429" plane="0 -1 0 -11.5" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="430" plane="-0 0 1 -0.25" album="PQ" material="pq_wood_2" texgens="1 0 0 16 0 -1 0 -736 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="431" plane="0 0 -1 -0.25" album="PQ" material="pq_wood_2" texgens="-1 0 0 16 0 -1 0 -736 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="432" owner="0" type="0" pos="-20.9085 80.6564 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -20.9085 0 1 0 80.6564 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1663" nextVertexID="2125">
                        <Vertices>
                            <Vertex pos="-3.09149 -2.15649 0.25" />
                            <Vertex pos="-2.8796 2.15648 0.25" />
                            <Vertex pos="2.9085 -2.15647 0.25" />
                            <Vertex pos="3.0915 1.56837 0.25" />
                            <Vertex pos="-3.09149 -2.15649 -0.25" />
                            <Vertex pos="-2.8796 2.15648 -0.25" />
                            <Vertex pos="2.9085 -2.15647 -0.25" />
                            <Vertex pos="3.0915 1.56837 -0.25" />
                        </Vertices>
                        <Face id="1656" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0 1 0 138.014 0.998795 -0.0490714 0 190.845 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1657" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0 1 -0.000558259 138.007 0.998731 -0.0490682 0.0113761 191.015 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1658" plane="-0.998795 0.049071 0 -2.98195" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.0490714 0.998795 0 147.558 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1659" plane="2.54313e-006 -1 0 -2.15648" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -1 0 0 2618.14 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1660" plane="0.0980176 0.995185 0 -1.86384" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -1 0 0 2618.14 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1661" plane="0.998795 -0.0490695 0 -3.01081" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.04907 0.998795 0 128.714 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="433" owner="0" type="0" pos="-20.529 84.6543 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -20.529 0 1 0 84.6543 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1663" nextVertexID="2143">
                        <Vertices>
                            <Vertex pos="-3.25911 -1.84145 0.25" />
                            <Vertex pos="-2.6256 2.42957 0.25" />
                            <Vertex pos="2.712 -2.42957 0.25" />
                            <Vertex pos="3.2591 1.25904 0.25" />
                            <Vertex pos="-3.25911 -1.84145 -0.25" />
                            <Vertex pos="-2.6256 2.42957 -0.25" />
                            <Vertex pos="2.712 -2.42957 -0.25" />
                            <Vertex pos="3.2591 1.25904 -0.25" />
                        </Vertices>
                        <Face id="1656" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.0980196 0.995184 0 137.731 0.989178 -0.146721 0 189.033 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1657" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.0980259 0.995184 -0.000558077 137.723 0.989114 -0.146711 0.0113748 189.203 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1658" plane="-0.989178 0.146722 0 -2.95365" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.146721 0.989178 0 147.181 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1659" plane="-0.0980186 -0.995185 0 -2.15204" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.995184 0.0980196 0 2619.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1660" plane="0.195088 0.980786 0 -1.87066" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.995184 0.0980196 0 2619.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1661" plane="0.989178 -0.146717 0 -3.03911" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.146717 0.989179 0 128.344 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="434" owner="0" type="0" pos="-19.7591 88.593 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -19.7591 0 1 0 88.593 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1663" nextVertexID="2207">
                        <Vertices>
                            <Vertex pos="-3.39547 -1.50915 0.25" />
                            <Vertex pos="-2.34617 2.67968 0.25" />
                            <Vertex pos="2.48925 -2.67968 0.25" />
                            <Vertex pos="3.39547 0.93795 0.25" />
                            <Vertex pos="-3.39547 -1.50915 -0.25" />
                            <Vertex pos="-2.34617 2.67968 -0.25" />
                            <Vertex pos="2.48925 -2.67968 -0.25" />
                            <Vertex pos="3.39547 0.93795 -0.25" />
                        </Vertices>
                        <Face id="1656" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.195088 0.980786 0 137.124 0.970028 -0.242992 0 187.326 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1657" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.195094 0.980784 -0.000558476 137.117 0.969966 -0.242976 0.0113749 187.496 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1658" plane="-0.970028 0.242992 0 -2.92699" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.242992 0.970029 0 146.495 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1659" plane="-0.195089 -0.980786 0 -2.14257" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.980786 0.195088 0 2621.71 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1660" plane="0.290288 0.956939 0 -1.88323" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.980786 0.195088 0 2621.71 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1661" plane="0.970028 -0.242992 0 -3.06578" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.242993 0.970028 0 127.648 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="435" owner="0" type="0" pos="-18.6063 92.4345 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -18.6063 0 1 0 92.4345 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1663" nextVertexID="2215">
                        <Vertices>
                            <Vertex pos="-3.49894 -1.1618 0.25" />
                            <Vertex pos="-2.04434 2.90352 0.25" />
                            <Vertex pos="2.24266 -2.90352 0.25" />
                            <Vertex pos="3.49894 0.60743 0.25" />
                            <Vertex pos="-3.49894 -1.1618 -0.25" />
                            <Vertex pos="-2.04434 2.90352 -0.25" />
                            <Vertex pos="2.24266 -2.90352 -0.25" />
                            <Vertex pos="3.49894 0.60743 -0.25" />
                        </Vertices>
                        <Face id="1656" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.290289 0.956939 0 136.158 0.941543 -0.336893 0 185.793 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1657" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.290295 0.956937 -0.000557689 136.151 0.941482 -0.336871 0.0113781 185.963 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1658" plane="-0.941543 0.336892 0 -2.90301" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.336893 0.941543 0 145.45 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1659" plane="-0.290289 -0.956939 0 -2.12747" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.956939 0.290289 0 2623.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1660" plane="0.382682 0.92388 0 -1.90017" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.956939 0.290289 0 2623.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1661" plane="0.941541 -0.3369 0 -3.08975" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.336901 0.94154 0 126.611 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="436" owner="0" type="0" pos="58.6065 92.4344 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 58.6065 0 1 0 92.4344 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1663" nextVertexID="2215">
                        <Vertices>
                            <Vertex pos="2.04436 2.90352 0.25" />
                            <Vertex pos="3.49896 -1.16178 0.25" />
                            <Vertex pos="-3.49897 0.607422 0.25" />
                            <Vertex pos="-2.24274 -2.90351 0.25" />
                            <Vertex pos="2.04436 2.90352 -0.25" />
                            <Vertex pos="3.49896 -1.16178 -0.25" />
                            <Vertex pos="-3.49897 0.607422 -0.25" />
                            <Vertex pos="-2.24274 -2.90351 -0.25" />
                        </Vertices>
                        <Face id="1656" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.382679 -0.923881 0 121.611 -0.941543 -0.336893 0 185.793 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1657" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.382673 -0.923883 -0.000558729 121.603 -0.941482 -0.336871 0.0113781 185.963 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1658" plane="0.941543 0.336892 0 -2.90303" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.336893 -0.941543 0 130.884 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1659" plane="-0.38268 0.923881 0 -1.90017" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.923881 0.382679 0 2624.01 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1660" plane="0.290285 -0.95694 0 -2.12745" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.923881 0.382679 0 2624.01 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1661" plane="-0.941545 -0.336888 0 -3.0898" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.336885 -0.941546 0 112.042 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="437" owner="0" type="0" pos="59.7592 88.5929 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 59.7592 0 1 0 88.5929 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1663" nextVertexID="2207">
                        <Vertices>
                            <Vertex pos="2.34624 2.67966 0.25" />
                            <Vertex pos="3.39544 -1.50916 0.25" />
                            <Vertex pos="-3.39544 0.93792 0.25" />
                            <Vertex pos="-2.48924 -2.67966 0.25" />
                            <Vertex pos="2.34624 2.67966 -0.25" />
                            <Vertex pos="3.39544 -1.50916 -0.25" />
                            <Vertex pos="-3.39544 0.93792 -0.25" />
                            <Vertex pos="-2.48924 -2.67966 -0.25" />
                        </Vertices>
                        <Face id="1656" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.290286 -0.95694 0 120.524 -0.970034 -0.242971 0 187.329 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1657" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.29028 -0.956942 -0.000557777 120.516 -0.969971 -0.242955 0.0113749 187.499 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1658" plane="0.970034 0.24297 0 -2.92701" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.242971 -0.970034 0 129.874 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1659" plane="-0.290288 0.956939 0 -1.88318" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.95694 0.290286 0 2622.53 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1660" plane="0.195084 -0.980787 0 -2.14256" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.95694 0.290286 0 2622.53 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1661" plane="-0.970029 -0.24299 0 -3.06577" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.242988 -0.970029 0 111.033 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="438" owner="0" type="0" pos="60.529 84.6542 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 60.529 0 1 0 84.6542 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1663" nextVertexID="2143">
                        <Vertices>
                            <Vertex pos="2.62559 2.42955 0.25" />
                            <Vertex pos="3.2591 -1.84146 0.25" />
                            <Vertex pos="-3.2591 1.25905 0.25" />
                            <Vertex pos="-2.712 -2.42956 0.25" />
                            <Vertex pos="2.62559 2.42955 -0.25" />
                            <Vertex pos="3.2591 -1.84146 -0.25" />
                            <Vertex pos="-3.2591 1.25905 -0.25" />
                            <Vertex pos="-2.712 -2.42956 -0.25" />
                        </Vertices>
                        <Face id="1656" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.195086 -0.980786 0 119.722 -0.989178 -0.146721 0 189.032 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1657" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.19508 -0.980787 -0.00055804 119.714 -0.989114 -0.146712 0.0113748 189.202 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1658" plane="0.989178 0.146722 0 -2.95364" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.146721 -0.989178 0 129.154 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1659" plane="-0.195085 0.980786 0 -1.87066" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.980786 0.195086 0 2620.86 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1660" plane="0.0980163 -0.995185 0 -2.15204" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.980786 0.195086 0 2620.86 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1661" plane="-0.989179 -0.146716 0 -3.03911" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.146717 -0.989179 0 110.309 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="439" owner="0" type="0" pos="60.9085 80.6564 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 60.9085 0 1 0 80.6564 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1663" nextVertexID="2125">
                        <Vertices>
                            <Vertex pos="2.87959 2.15639 0.25" />
                            <Vertex pos="3.09149 -2.65639 0.25" />
                            <Vertex pos="-3.09149 1.56828 0.25" />
                            <Vertex pos="-2.90849 -2.65639 0.25" />
                            <Vertex pos="2.87959 2.15639 -0.25" />
                            <Vertex pos="3.09149 -2.65639 -0.25" />
                            <Vertex pos="-3.09149 1.56828 -0.25" />
                            <Vertex pos="-2.90849 -2.65639 -0.25" />
                        </Vertices>
                        <Face id="1656" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.0980178 -0.995185 0 119.28 -0.998795 -0.0490736 0 190.845 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1657" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.0980114 -0.995185 -0.000558275 119.273 -0.998731 -0.0490704 0.0113761 191.014 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1658" plane="0.999032 0.0439858 0 -2.97166" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.0490737 -0.998795 0 128.799 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1659" plane="-0.0980178 0.995185 0 -1.86375" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.995185 0.0980178 0 2619.06 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1660" plane="0 -1 0 -2.65639" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.995185 0.0980178 0 2619.06 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1661" plane="-0.999063 -0.0432761 0 -3.02073" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.0490723 -0.998795 0 109.958 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="442" owner="0" type="0" pos="-17.0818 96.1418 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -17.0818 0 1 0 96.1418 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1657" nextVertexID="2209">
                        <Vertices>
                            <Vertex pos="-3.56889 -0.803757 0.25" />
                            <Vertex pos="-1.72269 3.09985 0.25" />
                            <Vertex pos="1.9744 -3.09985 0.25" />
                            <Vertex pos="3.56889 0.271408 0.25" />
                            <Vertex pos="-3.56889 -0.803757 -0.25" />
                            <Vertex pos="-1.72269 3.09985 -0.25" />
                            <Vertex pos="1.9744 -3.09985 -0.25" />
                            <Vertex pos="3.56889 0.271408 -0.25" />
                        </Vertices>
                        <Face id="1650" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.382682 0.92388 0 134.934 0.903995 -0.427542 0 184.488 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1651" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.382688 0.923878 -0.000557576 134.926 0.903937 -0.427515 0.0113774 184.658 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1652" plane="-0.903996 0.427542 0 -2.88262" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.427542 0.903996 0 144.157 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1653" plane="-0.382681 -0.923881 0 -2.10832" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.92388 0.382682 0 2624.66 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1654" plane="0.4714 0.881919 0 -1.92174" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.92388 0.382682 0 2624.66 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1655" plane="0.903989 -0.427555 0 -3.1102" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.427553 0.903991 0 125.318 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="443" owner="0" type="0" pos="57.0819 96.1417 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 57.0819 0 1 0 96.1417 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1657" nextVertexID="2209">
                        <Vertices>
                            <Vertex pos="1.7226 3.09985 0.25" />
                            <Vertex pos="3.56891 -0.803757 0.25" />
                            <Vertex pos="-3.56892 0.271477 0.25" />
                            <Vertex pos="-1.97441 -3.09985 0.25" />
                            <Vertex pos="1.7226 3.09985 -0.25" />
                            <Vertex pos="3.56891 -0.803757 -0.25" />
                            <Vertex pos="-3.56892 0.271477 -0.25" />
                            <Vertex pos="-1.97441 -3.09985 -0.25" />
                        </Vertices>
                        <Face id="1650" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.471398 -0.881921 0 122.994 -0.903986 -0.427561 0 184.485 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1651" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.471392 -0.881923 -0.000558912 122.986 -0.903928 -0.427534 0.0113774 184.655 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1652" plane="0.903986 0.427563 0 -2.88259" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.42756 -0.903987 0 132.205 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1653" plane="-0.471397 0.881921 0 -1.9218" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.881921 0.471398 0 2625.25 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1654" plane="0.38268 -0.923881 0 -2.10833" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.881921 0.471398 0 2625.25 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1655" plane="-0.903991 -0.427552 0 -3.1102" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.427553 -0.903991 0 113.361 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="450" owner="0" type="0" pos="-15.2002 99.6791 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -15.2002 0 1 0 99.6791 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1651" nextVertexID="2201">
                        <Vertices>
                            <Vertex pos="-3.6043 -0.437469 0.25" />
                            <Vertex pos="-1.38451 3.26591 0.25" />
                            <Vertex pos="1.68729 -3.26591 0.25" />
                            <Vertex pos="3.6043 -0.0674973 0.25" />
                            <Vertex pos="-3.6043 -0.437469 -0.25" />
                            <Vertex pos="-1.38451 3.26591 -0.25" />
                            <Vertex pos="1.68729 -3.26591 -0.25" />
                            <Vertex pos="3.6043 -0.0674973 -0.25" />
                        </Vertices>
                        <Face id="1644" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.4714 0.88192 0 133.434 0.857722 -0.514114 0 183.46 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1645" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.471405 0.881917 -0.000558476 133.426 0.857666 -0.514081 0.0113771 183.631 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1646" plane="-0.857721 0.514116 0 -2.86657" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.514114 0.857722 0 142.609 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1647" plane="-0.471401 -0.881919 0 -2.08488" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.88192 0.4714 0 2625.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1648" plane="0.555569 0.83147 0 -1.94632" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.88192 0.4714 0 2625.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1649" plane="0.857734 -0.514094 0 -3.12623" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.514093 0.857734 0 123.766 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="451" owner="0" type="0" pos="-12.9795 103.013 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.9795 0 1 0 103.013 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1651" nextVertexID="2201">
                        <Vertices>
                            <Vertex pos="-3.60519 -0.0675125 0.25" />
                            <Vertex pos="-1.03279 3.4009 0.25" />
                            <Vertex pos="1.3836 -3.40091 0.25" />
                            <Vertex pos="3.60519 -0.405426 0.25" />
                            <Vertex pos="-3.60519 -0.0675125 -0.25" />
                            <Vertex pos="-1.03279 3.4009 -0.25" />
                            <Vertex pos="1.3836 -3.40091 -0.25" />
                            <Vertex pos="3.60519 -0.405426 -0.25" />
                        </Vertices>
                        <Face id="1644" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.555568 0.831471 0 131.78 0.803201 -0.595708 0 182.751 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1645" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.555574 0.831467 -0.000557467 131.772 0.803149 -0.59567 0.0113782 182.921 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1646" plane="-0.803202 0.595707 0 -2.85548" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.595709 0.8032 0 140.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1647" plane="-0.555569 -0.83147 0 -2.05907" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.831471 0.555568 0 2626.55 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1648" plane="0.634397 0.773007 0 -1.97373" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.831471 0.555568 0 2626.55 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1649" plane="0.803209 -0.595697 0 -3.13723" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.595697 0.803209 0 122.076 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="452" owner="0" type="0" pos="-10.4412 106.11 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.4412 0 1 0 106.11 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1651" nextVertexID="2199">
                        <Vertices>
                            <Vertex pos="-3.57112 0.303513 0.25" />
                            <Vertex pos="-0.671519 3.50281 0.25" />
                            <Vertex pos="1.06685 -3.50281 0.25" />
                            <Vertex pos="3.57112 -0.73983 0.25" />
                            <Vertex pos="-3.57112 0.303513 -0.25" />
                            <Vertex pos="-0.671519 3.50281 -0.25" />
                            <Vertex pos="1.06685 -3.50281 -0.25" />
                            <Vertex pos="3.57112 -0.73983 -0.25" />
                        </Vertices>
                        <Face id="1644" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.634396 0.773008 0 129.977 0.74096 -0.671549 0 182.393 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1645" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.634401 0.773004 -0.000558686 129.969 0.740912 -0.671506 0.0113767 182.563 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1646" plane="-0.740959 0.67155 0 -2.84988" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.671549 0.74096 0 139.091 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1647" plane="-0.634397 -0.773008 0 -2.03089" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.773008 0.634396 0 2627 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1648" plane="0.707107 0.707107 0 -2.00202" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.773008 0.634396 0 2627 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1649" plane="0.740945 -0.671566 0 -3.14285" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.671566 0.740944 0 120.25 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="453" owner="0" type="0" pos="50.4413 106.11 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 50.4413 0 1 0 106.11 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1651" nextVertexID="2199">
                        <Vertices>
                            <Vertex pos="0.671532 3.50278 0.25" />
                            <Vertex pos="3.57113 0.303574 0.25" />
                            <Vertex pos="-3.57113 -0.739861 0.25" />
                            <Vertex pos="-1.0669 -3.50278 0.25" />
                            <Vertex pos="0.671532 3.50278 -0.25" />
                            <Vertex pos="3.57113 0.303574 -0.25" />
                            <Vertex pos="-3.57113 -0.739861 -0.25" />
                            <Vertex pos="-1.0669 -3.50278 -0.25" />
                        </Vertices>
                        <Face id="1644" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.707105 -0.707109 0 128.128 -0.740949 -0.671561 0 182.393 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1645" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.7071 -0.707113 -0.000557612 128.12 -0.740901 -0.671517 0.0113767 182.563 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1646" plane="0.74095 0.67156 0 -2.8499" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.67156 -0.74095 0 137.242 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1647" plane="-0.707105 0.707109 0 -2.002" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.707109 0.707105 0 2627.09 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1648" plane="0.634396 -0.773008 0 -2.03084" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.707109 0.707105 0 2627.09 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1649" plane="-0.740943 -0.671567 0 -3.14287" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.671568 -0.740943 0 118.407 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="454" owner="0" type="0" pos="52.9795 103.013 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 52.9795 0 1 0 103.013 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1651" nextVertexID="2201">
                        <Vertices>
                            <Vertex pos="1.03287 3.40089 0.25" />
                            <Vertex pos="3.60517 -0.0675125 0.25" />
                            <Vertex pos="-3.60516 -0.405464 0.25" />
                            <Vertex pos="-1.38363 -3.40089 0.25" />
                            <Vertex pos="1.03287 3.40089 -0.25" />
                            <Vertex pos="3.60517 -0.0675125 -0.25" />
                            <Vertex pos="-3.60516 -0.405464 -0.25" />
                            <Vertex pos="-1.38363 -3.40089 -0.25" />
                        </Vertices>
                        <Face id="1644" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.634395 -0.773009 0 126.315 -0.803212 -0.595693 0 182.752 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1645" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.63439 -0.773013 -0.000559123 126.307 -0.80316 -0.595654 0.0113782 182.922 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1646" plane="0.803213 0.595692 0 -2.8555" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.595694 -0.803212 0 135.447 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1647" plane="-0.634395 0.773009 0 -1.97367" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.773009 0.634395 0 2626.82 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1648" plane="0.555567 -0.831472 0 -2.05905" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.773009 0.634395 0 2626.82 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1649" plane="-0.803211 -0.595695 0 -3.13724" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.595692 -0.803213 0 116.598 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="455" owner="0" type="0" pos="55.2002 99.6791 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 55.2002 0 1 0 99.6791 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1651" nextVertexID="2201">
                        <Vertices>
                            <Vertex pos="1.3845 3.26595 0.25" />
                            <Vertex pos="3.6043 -0.437546 0.25" />
                            <Vertex pos="-3.60431 -0.0674591 0.25" />
                            <Vertex pos="-1.68722 -3.26594 0.25" />
                            <Vertex pos="1.3845 3.26595 -0.25" />
                            <Vertex pos="3.6043 -0.437546 -0.25" />
                            <Vertex pos="-3.60431 -0.0674591 -0.25" />
                            <Vertex pos="-1.68722 -3.26594 -0.25" />
                        </Vertices>
                        <Face id="1644" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.555568 -0.831471 0 124.566 -0.857728 -0.514104 0 183.46 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1645" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.555563 -0.831474 -0.000557886 124.559 -0.857672 -0.514071 0.0113771 183.63 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1646" plane="0.857727 0.514105 0 -2.86656" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.514105 -0.857727 0 133.729 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1647" plane="-0.555569 0.83147 0 -1.94635" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.831471 0.555568 0 2626.2 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1648" plane="0.471399 -0.88192 0 -2.08494" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.831471 0.555568 0 2626.2 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1649" plane="-0.857729 -0.514101 0 -3.1262" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.514101 -0.857729 0 114.887 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="458" owner="0" type="0" pos="-7.60975 108.941 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -7.60975 0 1 0 108.941 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1645" nextVertexID="2193">
                        <Vertices>
                            <Vertex pos="-3.50293 0.671371 0.25" />
                            <Vertex pos="-0.303432 3.57128 0.25" />
                            <Vertex pos="0.739704 -3.57127 0.25" />
                            <Vertex pos="3.50293 -1.06683 0.25" />
                            <Vertex pos="-3.50293 0.671371 -0.25" />
                            <Vertex pos="-0.303432 3.57128 -0.25" />
                            <Vertex pos="0.739704 -3.57127 -0.25" />
                            <Vertex pos="3.50293 -1.06683 -0.25" />
                        </Vertices>
                        <Face id="1638" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.707107 0.707107 0 128.143 0.671565 -0.740946 0 182.394 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1639" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.707111 0.707102 -0.000557648 128.135 0.671521 -0.740898 0.0113767 182.564 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1640" plane="-0.671566 0.740945 0 -2.8499" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.740946 0.671564 0 137.256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1641" plane="-0.707108 -0.707106 0 -2.00222" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.707107 0.707107 0 2627.09 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1642" plane="0.773014 0.634389 0 -2.03103" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.707107 0.707107 0 2627.09 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1643" plane="0.671558 -0.740952 0 -3.1429" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.740952 0.671558 0 118.42 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="459" owner="0" type="0" pos="47.6099 108.941 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 47.6099 0 1 0 108.941 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1645" nextVertexID="2193">
                        <Vertices>
                            <Vertex pos="0.303349 3.57127 0.25" />
                            <Vertex pos="3.50294 0.671371 0.25" />
                            <Vertex pos="-3.50294 -1.06675 0.25" />
                            <Vertex pos="-0.739712 -3.57127 0.25" />
                            <Vertex pos="0.303349 3.57127 -0.25" />
                            <Vertex pos="3.50294 0.671371 -0.25" />
                            <Vertex pos="-3.50294 -1.06675 -0.25" />
                            <Vertex pos="-0.739712 -3.57127 -0.25" />
                        </Vertices>
                        <Face id="1638" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.773012 -0.634391 0 129.99 -0.671553 -0.740957 0 182.391 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1639" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.773008 -0.634396 -0.00055876 129.982 -0.671509 -0.740909 0.0113767 182.561 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1640" plane="0.671553 0.740957 0 -2.84987" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.740956 -0.671553 0 139.106 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1641" plane="-0.773013 0.63439 0 -2.03109" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.634391 0.773012 0 2627 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1642" plane="0.707105 -0.707108 0 -2.00222" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.634391 0.773012 0 2627 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1643" plane="-0.671569 -0.740942 0 -3.14287" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.740941 -0.67157 0 120.262 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="464" owner="0" type="0" pos="-4.51242 111.48 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -4.51242 0 1 0 111.48 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1639" nextVertexID="2177">
                        <Vertices>
                            <Vertex pos="-3.40076 1.03303 0.25" />
                            <Vertex pos="0.0673237 3.6051 0.25" />
                            <Vertex pos="0.405606 -3.6051 0.25" />
                            <Vertex pos="3.40076 -1.38374 0.25" />
                            <Vertex pos="-3.40076 1.03303 -0.25" />
                            <Vertex pos="0.0673237 3.6051 -0.25" />
                            <Vertex pos="0.405606 -3.6051 -0.25" />
                            <Vertex pos="3.40076 -1.38374 -0.25" />
                        </Vertices>
                        <Face id="1632" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.773013 0.63439 0 126.305 0.595697 -0.803209 0 182.756 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1633" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.773017 0.634385 -0.00055905 126.297 0.595658 -0.803157 0.0113782 182.926 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1634" plane="-0.595694 0.803211 0 -2.85556" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.80321 0.595696 0 135.435 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1635" plane="-0.773014 -0.634389 0 -1.9735" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.63439 0.773013 0 2626.82 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1636" plane="0.831469 0.555571 0 -2.05887" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.63439 0.773013 0 2626.82 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1637" plane="0.5957 -0.803207 0 -3.13726" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.80321 0.595696 0 116.591 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="465" owner="0" type="0" pos="-1.17902 113.7 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 -1.17902 0 1 0 113.7 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1639" nextVertexID="2133">
                        <Vertices>
                            <Vertex pos="-3.26608 1.3845 0.25" />
                            <Vertex pos="0.437722 3.60439 0.25" />
                            <Vertex pos="0.0673795 -3.60439 0.25" />
                            <Vertex pos="3.26608 -1.68716 0.25" />
                            <Vertex pos="-3.26608 1.3845 -0.25" />
                            <Vertex pos="0.437722 3.60439 -0.25" />
                            <Vertex pos="0.0673795 -3.60439 -0.25" />
                            <Vertex pos="3.26608 -1.68716 -0.25" />
                        </Vertices>
                        <Face id="1632" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.83147 0.55557 0 124.574 0.51409 -0.857736 0 183.461 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1633" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.831473 0.555565 -0.000557908 124.566 0.514057 -0.857681 0.0113771 183.632 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1634" plane="-0.514089 0.857737 0 -2.86659" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.857736 0.51409 0 133.74 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1635" plane="-0.83147 -0.555569 0 -1.94647" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.55557 0.83147 0 2626.2 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1636" plane="0.881923 0.471393 0 -2.08512" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.55557 0.83147 0 2626.2 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1637" plane="0.514104 -0.857728 0 -3.12623" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.857728 0.514104 0 114.899 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="466" owner="0" type="0" pos="41.1791 113.7 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 41.1791 0 1 0 113.7 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1639" nextVertexID="2133">
                        <Vertices>
                            <Vertex pos="-0.437782 3.60442 0.25" />
                            <Vertex pos="3.26612 1.38442 0.25" />
                            <Vertex pos="-3.26611 -1.68707 0.25" />
                            <Vertex pos="-0.0673332 -3.60442 0.25" />
                            <Vertex pos="-0.437782 3.60442 -0.25" />
                            <Vertex pos="3.26612 1.38442 -0.25" />
                            <Vertex pos="-3.26611 -1.68707 -0.25" />
                            <Vertex pos="-0.0673332 -3.60442 -0.25" />
                        </Vertices>
                        <Face id="1632" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.881923 -0.471393 0 133.452 -0.514098 -0.857732 0 183.46 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1633" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.88192 -0.471399 -0.000558556 133.444 -0.514064 -0.857676 0.0113771 183.63 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1634" plane="0.514096 0.857732 0 -2.86656" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.857732 -0.514098 0 142.625 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1635" plane="-0.881923 0.471394 0 -2.08519" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.471393 0.881923 0 2625.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1636" plane="0.831468 -0.555572 0 -1.94653" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.471393 0.881923 0 2625.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1637" plane="-0.514118 -0.85772 0 -3.1262" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.85772 -0.514117 0 123.778 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="467" owner="0" type="0" pos="44.5125 111.48 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 44.5125 0 1 0 111.48 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1639" nextVertexID="2177">
                        <Vertices>
                            <Vertex pos="-0.067276 3.60506 0.25" />
                            <Vertex pos="3.40073 1.03295 0.25" />
                            <Vertex pos="-3.40073 -1.38378 0.25" />
                            <Vertex pos="-0.405563 -3.60506 0.25" />
                            <Vertex pos="-0.067276 3.60506 -0.25" />
                            <Vertex pos="3.40073 1.03295 -0.25" />
                            <Vertex pos="-3.40073 -1.38378 -0.25" />
                            <Vertex pos="-0.405563 -3.60506 -0.25" />
                        </Vertices>
                        <Face id="1632" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.831468 -0.555573 0 131.763 -0.595707 -0.803202 0 182.752 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1633" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.831464 -0.555578 -0.000557409 131.756 -0.595669 -0.80315 0.0113782 182.922 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1634" plane="0.595708 0.803201 0 -2.85551" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.803201 -0.595708 0 140.902 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1635" plane="-0.831468 0.555572 0 -2.05881" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.555573 0.831468 0 2626.55 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1636" plane="0.773012 -0.634391 0 -1.97351" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.555573 0.831468 0 2626.55 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1637" plane="-0.595684 -0.803219 0 -3.13724" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.803219 -0.595683 0 122.067 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="470" owner="0" type="0" pos="2.35836 115.582 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 2.35836 0 1 0 115.582 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1627" nextVertexID="2085">
                        <Vertices>
                            <Vertex pos="-3.09966 1.72271 0.25" />
                            <Vertex pos="0.803547 3.56882 0.25" />
                            <Vertex pos="-0.271307 -3.56882 0.25" />
                            <Vertex pos="3.09966 -1.97449 0.25" />
                            <Vertex pos="-3.09966 1.72271 -0.25" />
                            <Vertex pos="0.803547 3.56882 -0.25" />
                            <Vertex pos="-0.271307 -3.56882 -0.25" />
                            <Vertex pos="3.09966 -1.97449 -0.25" />
                        </Vertices>
                        <Face id="1620" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.881923 0.471393 0 122.982 0.42756 -0.903987 0 184.486 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1621" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.881926 0.471388 -0.000558854 122.974 0.427532 -0.903929 0.0113774 184.656 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1622" plane="-0.42756 0.903987 0 -2.8826" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.903988 0.427559 0 132.192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1623" plane="-0.881923 -0.471393 0 -1.92159" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.471393 0.881923 0 2625.25 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1624" plane="0.923879 0.382684 0 -2.10811" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.471393 0.881923 0 2625.25 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1625" plane="0.427551 -0.903991 0 -3.11018" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.903991 0.427551 0 113.348 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="471" owner="0" type="0" pos="37.6417 115.582 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 37.6417 0 1 0 115.582 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1627" nextVertexID="2085">
                        <Vertices>
                            <Vertex pos="-0.803478 3.5688 0.25" />
                            <Vertex pos="3.09962 1.7227 0.25" />
                            <Vertex pos="-3.09962 -1.97455 0.25" />
                            <Vertex pos="0.271278 -3.56879 0.25" />
                            <Vertex pos="-0.803478 3.5688 -0.25" />
                            <Vertex pos="3.09962 1.7227 -0.25" />
                            <Vertex pos="-3.09962 -1.97455 -0.25" />
                            <Vertex pos="0.271278 -3.56879 -0.25" />
                        </Vertices>
                        <Face id="1620" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.923878 -0.382686 0 134.915 -0.427568 -0.903983 0 184.485 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1621" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.923876 -0.382692 -0.000557528 134.907 -0.427541 -0.903925 0.0113774 184.656 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1622" plane="0.427568 0.903983 0 -2.88259" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.903983 -0.427568 0 144.143 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1623" plane="-0.923879 0.382686 0 -2.10805" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.382686 0.923878 0 2624.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1624" plane="0.881922 -0.471394 0 -1.92156" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.382686 0.923878 0 2624.67 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1625" plane="-0.427539 -0.903997 0 -3.1102" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.903996 -0.427541 0 125.307 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="474" owner="0" type="0" pos="6.06546 117.106 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 6.06546 0 1 0 117.106 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2033">
                        <Vertices>
                            <Vertex pos="-2.90356 2.04436 0.25" />
                            <Vertex pos="1.16184 3.49895 0.25" />
                            <Vertex pos="-0.607445 -3.49895 0.25" />
                            <Vertex pos="2.90356 -2.24265 0.25" />
                            <Vertex pos="-2.90356 2.04436 -0.25" />
                            <Vertex pos="1.16184 3.49895 -0.25" />
                            <Vertex pos="-0.607445 -3.49895 -0.25" />
                            <Vertex pos="2.90356 -2.24265 -0.25" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.923879 0.382684 0 121.613 0.336885 -0.941546 0 185.793 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.923881 0.382678 -0.000558787 121.606 0.336864 -0.941485 0.0113781 185.963 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.336885 0.941546 0 -2.90302" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.941546 0.336885 0 130.888 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.92388 -0.382683 0 -1.9002" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.382684 0.92388 0 2624.01 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.956939 0.290288 0 -2.12751" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.382684 0.92388 0 2624.01 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.336901 -0.94154 0 -3.08976" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.94154 0.336901 0 112.048 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="475" owner="0" type="0" pos="33.9345 117.106 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 33.9345 0 1 0 117.106 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2033">
                        <Vertices>
                            <Vertex pos="-1.16206 3.49903 0.25" />
                            <Vertex pos="2.90374 2.04433 0.25" />
                            <Vertex pos="-2.90374 -2.24259 0.25" />
                            <Vertex pos="0.607594 -3.49902 0.25" />
                            <Vertex pos="-1.16206 3.49903 -0.25" />
                            <Vertex pos="2.90374 2.04433 -0.25" />
                            <Vertex pos="-2.90374 -2.24259 -0.25" />
                            <Vertex pos="0.607594 -3.49902 -0.25" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.956941 -0.290282 0 136.175 -0.336876 -0.941549 0 185.793 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.956939 -0.290288 -0.000557771 136.167 -0.336855 -0.941488 0.0113781 185.963 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.336876 0.941549 0 -2.90304" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.941549 -0.336876 0 145.464 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.956941 0.290282 0 -2.12773" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.290282 0.956941 0 2623.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.923879 -0.382686 0 -1.90037" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.290282 0.956941 0 2623.29 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.336903 -0.941539 0 -3.08977" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.941541 -0.336899 0 126.623 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="478" owner="0" type="0" pos="9.90695 118.259 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 9.90695 0 1 0 118.259 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="1977">
                        <Vertices>
                            <Vertex pos="-2.67965 2.34614 0.25" />
                            <Vertex pos="1.5091 3.39545 0.25" />
                            <Vertex pos="-0.937932 -3.39545 0.25" />
                            <Vertex pos="2.67965 -2.48936 0.25" />
                            <Vertex pos="-2.67965 2.34614 -0.25" />
                            <Vertex pos="1.5091 3.39545 -0.25" />
                            <Vertex pos="-0.937932 -3.39545 -0.25" />
                            <Vertex pos="2.67965 -2.48936 -0.25" />
                        </Vertices>
                        <Face id="1608" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.956939 0.290289 0 120.525 0.242996 -0.970027 0 187.326 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.956941 0.290283 -0.000557809 120.517 0.24298 -0.969965 0.0113749 187.495 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="-0.242998 0.970027 0 -2.92697" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.970027 0.242996 0 129.871 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.956939 -0.290289 0 -1.8832" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.290289 0.956939 0 2622.53 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.980785 0.195089 0 -2.14252" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.290289 0.956939 0 2622.53 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="0.242963 -0.970035 0 -3.06582" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.970035 0.242966 0 111.029 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="479" owner="0" type="0" pos="30.0929 118.259 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 30.0929 0 1 0 118.259 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="1977">
                        <Vertices>
                            <Vertex pos="-1.50891 3.39534 0.25" />
                            <Vertex pos="2.67945 2.34624 0.25" />
                            <Vertex pos="-2.67945 -2.48934 0.25" />
                            <Vertex pos="0.937782 -3.39534 0.25" />
                            <Vertex pos="-1.50891 3.39534 -0.25" />
                            <Vertex pos="2.67945 2.34624 -0.25" />
                            <Vertex pos="-2.67945 -2.48934 -0.25" />
                            <Vertex pos="0.937782 -3.39534 -0.25" />
                        </Vertices>
                        <Face id="1608" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.980785 -0.195092 0 137.108 -0.242974 -0.970033 0 187.325 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.980784 -0.195098 -0.00055843 137.101 -0.242958 -0.96997 0.0113749 187.495 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="0.242973 0.970033 0 -2.92697" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.970033 -0.242974 0 146.475 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.980785 0.195092 0 -2.14232" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.195092 0.980785 0 2621.71 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.956941 -0.290282 0 -1.88301" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.195092 0.980785 0 2621.71 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="-0.242962 -0.970036 0 -3.06576" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.970035 -0.242964 0 127.638 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="482" owner="0" type="0" pos="13.8456 119.029 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 13.8456 0 1 0 119.029 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1447" nextVertexID="1929">
                        <Vertices>
                            <Vertex pos="-2.42958 2.62565 0.25" />
                            <Vertex pos="1.84145 3.25915 0.25" />
                            <Vertex pos="-1.25902 -3.25915 0.25" />
                            <Vertex pos="2.42957 -2.71194 0.25" />
                            <Vertex pos="-2.42958 2.62565 -0.25" />
                            <Vertex pos="1.84145 3.25915 -0.25" />
                            <Vertex pos="-1.25902 -3.25915 -0.25" />
                            <Vertex pos="2.42957 -2.71194 -0.25" />
                        </Vertices>
                        <Face id="1440" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.980785 0.19509 0 119.723 0.14672 -0.989178 0 189.037 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1441" plane="0 -0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.980786 0.195084 -0.000558083 119.715 0.146711 -0.989114 0.0113748 189.207 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1442" plane="-0.14672 0.989178 0 -2.9537" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.989178 0.146721 0 129.155 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1443" plane="-0.980786 -0.195089 0 -1.87066" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.19509 0.980786 0 2620.86 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1444" plane="0.995184 0.0980208 0 -2.15205" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.19509 0.980786 0 2620.86 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1445" plane="0.146744 -0.989174 0 -3.03911" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.989175 0.146743 0 110.315 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="483" owner="0" type="0" pos="26.1543 119.029 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 26.1543 0 1 0 119.029 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1447" nextVertexID="1929">
                        <Vertices>
                            <Vertex pos="-1.84168 3.25916 0.25" />
                            <Vertex pos="2.42976 2.62555 0.25" />
                            <Vertex pos="-2.42976 -2.71195 0.25" />
                            <Vertex pos="1.25921 -3.25915 0.25" />
                            <Vertex pos="-1.84168 3.25916 -0.25" />
                            <Vertex pos="2.42976 2.62555 -0.25" />
                            <Vertex pos="-2.42976 -2.71195 -0.25" />
                            <Vertex pos="1.25921 -3.25915 -0.25" />
                        </Vertices>
                        <Face id="1440" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.995185 -0.0980137 0 137.744 -0.146729 -0.989177 0 189.033 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1441" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.995184 -0.09802 -0.00055862 137.737 -0.14672 -0.989113 0.0113748 189.202 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1442" plane="0.14673 0.989177 0 -2.95365" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.989177 -0.146729 0 147.197 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1443" plane="-0.995185 0.0980136 0 -2.15225" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.0980137 0.995185 0 2619.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1444" plane="0.980785 -0.195092 0 -1.87085" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.0980137 0.995185 0 2619.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1445" plane="-0.146727 -0.989177 0 -3.03911" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.989177 -0.146729 0 128.354 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="486" owner="0" type="0" pos="17.8436 119.409 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 17.8436 0 1 0 119.409 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1435" nextVertexID="1913">
                        <Vertices>
                            <Vertex pos="-2.15648 2.87959 0.25" />
                            <Vertex pos="2.15648 3.09148 0.25" />
                            <Vertex pos="-1.56836 -3.09148 0.25" />
                            <Vertex pos="2.15648 -2.90848 0.25" />
                            <Vertex pos="-2.15648 2.87959 -0.25" />
                            <Vertex pos="2.15648 3.09148 -0.25" />
                            <Vertex pos="-1.56836 -3.09148 -0.25" />
                            <Vertex pos="2.15648 -2.90848 -0.25" />
                        </Vertices>
                        <Face id="1428" plane="0 -0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.995184 0.0980211 0 119.286 0.0490714 -0.998795 0 190.845 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1429" plane="0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="0.995185 0.0980148 -0.000558313 119.278 0.0490682 -0.998731 0.0113761 191.015 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1430" plane="-0.0490715 0.998795 0 -2.98194" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.998796 0.0490714 0 128.806 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1431" plane="-0.995184 -0.0980211 0 -1.86384" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.0980212 0.995184 0 2619.06 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1432" plane="1 -9.5368e-007 0 -2.15648" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 -0.0980212 0.995184 0 2619.06 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1433" plane="0.0490722 -0.998795 0 -3.0108" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.998795 0.0490699 0 109.964 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="487" owner="0" type="0" pos="22.1563 119.409 -34.25" rot="1 0 0 0" scale="" transform="1 0 0 22.1563 0 1 0 119.409 0 0 1 -34.25 0 0 0 1" group="-1" locked="0" nextFaceID="1435" nextVertexID="1913">
                        <Vertices>
                            <Vertex pos="-2.15628 3.09149 0.25" />
                            <Vertex pos="2.15628 2.87961 0.25" />
                            <Vertex pos="-2.15628 -2.9085 0.25" />
                            <Vertex pos="1.5682 -3.09149 0.25" />
                            <Vertex pos="-2.15628 3.09149 -0.25" />
                            <Vertex pos="2.15628 2.87961 -0.25" />
                            <Vertex pos="-2.15628 -2.9085 -0.25" />
                            <Vertex pos="1.5682 -3.09149 -0.25" />
                        </Vertices>
                        <Face id="1428" plane="-0 0 1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 0 138.002 -0.0490761 -0.998795 0 190.845 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1429" plane="-0 0 -1 -0.25" album="PQ" material="pq_hot_2_med" texgens="1 0 -0.000558272 137.994 -0.0490729 -0.99873 0.0113761 191.014 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1430" plane="0.0490725 0.998795 0 -2.98195" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.998795 -0.0490761 0 147.545 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1431" plane="-1 6.35784e-007 0 -2.15628" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0 1 0 2618.15 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1432" plane="0.995185 -0.0980137 0 -1.86366" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0 1 0 2618.15 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1433" plane="-0.0490727 -0.998795 0 -3.01081" album="PQ" material="pq_hot_2_med" texgens="0 0 -1 16 0.998795 -0.0490748 0 128.701 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="508" owner="0" type="0" pos="-24.144 80.6809 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.144 0 1 0 80.6809 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.355947 -2.18098 0.75" />
                            <Vertex pos="-0.141651 2.181 0.75" />
                            <Vertex pos="0.144049 -2.18099 0.75" />
                            <Vertex pos="0.355947 2.13199 0.75" />
                            <Vertex pos="-0.355947 -2.18098 -0.75" />
                            <Vertex pos="-0.141651 2.181 -0.75" />
                            <Vertex pos="0.144049 -2.18099 -0.75" />
                            <Vertex pos="0.355947 2.13199 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0 1 0 139.583 0.998795 -0.0490695 0 15.9049 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0 0.999999 -0.00165423 139.505 0.998227 -0.0490415 0.0337306 17.5148 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.998795 0.049069 0 -0.2485" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.0490695 0.998795 0 140.533 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-1.52589e-005 -1 0 -2.18099" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -1 0 0 2825.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.0980212 0.995184 0 -2.15661" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -1 0 0 2825.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.998795 -0.0490713 0 -0.250899" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.0490714 0.998795 0 138.963 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="509" owner="0" type="0" pos="-23.7202 84.9971 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -23.7202 0 1 0 84.9971 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.565557 -2.13526 0.75" />
                            <Vertex pos="0.07514 2.18427 0.75" />
                            <Vertex pos="-0.0679455 -2.18427 0.75" />
                            <Vertex pos="0.565556 2.08672 0.75" />
                            <Vertex pos="-0.565557 -2.13526 -0.75" />
                            <Vertex pos="0.07514 2.18427 -0.75" />
                            <Vertex pos="-0.0679455 -2.18427 -0.75" />
                            <Vertex pos="0.565556 2.08672 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.0980196 0.995185 0 139.547 0.989178 -0.146721 0 15.7532 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.0980749 0.995178 -0.00165362 139.469 0.988615 -0.146637 0.0337303 17.3629 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.989178 0.14672 0 -0.246151" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.146721 0.989178 0 140.489 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.0980186 -0.995185 0 -2.18041" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.995185 0.0980196 0 2825.37 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.19509 0.980785 0 -2.15696" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.995185 0.0980196 0 2825.37 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.989178 -0.146721 0 -0.253269" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.146721 0.989178 0 138.919 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="510" owner="0" type="0" pos="-22.8752 89.2508 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -22.8752 0 1 0 89.2508 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.76985 -2.06942 0.75" />
                            <Vertex pos="0.291357 2.16698 0.75" />
                            <Vertex pos="-0.279444 -2.16698 0.75" />
                            <Vertex pos="0.769848 2.02182 0.75" />
                            <Vertex pos="-0.76985 -2.06942 -0.75" />
                            <Vertex pos="0.291357 2.16698 -0.75" />
                            <Vertex pos="-0.279444 -2.16698 -0.75" />
                            <Vertex pos="0.769848 2.02182 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.195088 0.980786 0 139.51 0.970029 -0.242989 0 15.6111 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.195142 0.980773 -0.00165453 139.432 0.969477 -0.242851 0.0337308 17.2213 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.970029 0.24299 0 -0.243929" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.24299 0.970029 0 140.445 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.195108 -0.980782 0 -2.17985" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.980786 0.195088 0 2825.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.2903 0.956936 0 -2.15824" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.980786 0.195088 0 2825.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.970028 -0.242992 0 -0.255489" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.242992 0.970028 0 138.874 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="511" owner="0" type="0" pos="-21.6173 93.401 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.6173 0 1 0 93.401 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.966534 -1.98317 0.75" />
                            <Vertex pos="0.504566 2.12832 0.75" />
                            <Vertex pos="-0.488064 -2.12831 0.75" />
                            <Vertex pos="0.966534 1.93697 0.75" />
                            <Vertex pos="-0.966534 -1.98317 -0.75" />
                            <Vertex pos="0.504566 2.12832 -0.75" />
                            <Vertex pos="-0.488064 -2.12831 -0.75" />
                            <Vertex pos="0.966534 1.93697 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.290288 0.956939 0 139.415 0.941545 -0.336886 0 15.4835 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.290341 0.956922 -0.00165431 139.337 0.94101 -0.336694 0.0337292 17.094 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.941545 0.336887 0 -0.241931" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.336887 0.941545 0 140.344 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.290284 -0.956941 0 -2.17834" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.956939 0.290288 0 2825.65 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.38267 0.923885 0 -2.1594" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.956939 0.290288 0 2825.65 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.941543 -0.336893 0 -0.25748" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.336893 0.941543 0 138.771 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="512" owner="0" type="0" pos="-19.9586 97.4076 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.9586 0 1 0 97.4076 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-1.15411 -1.87833 0.75" />
                            <Vertex pos="0.713196 2.06968 0.75" />
                            <Vertex pos="-0.692131 -2.06969 0.75" />
                            <Vertex pos="1.15411 1.834 0.75" />
                            <Vertex pos="-1.15411 -1.87833 -0.75" />
                            <Vertex pos="0.713196 2.06968 -0.75" />
                            <Vertex pos="-0.692131 -2.06969 -0.75" />
                            <Vertex pos="1.15411 1.834 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.382681 0.923881 0 139.329 0.903986 -0.427562 0 15.3728 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.382732 0.923858 -0.00165523 139.251 0.903472 -0.427319 0.0337282 16.9829 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.903986 0.427561 0 -0.240195" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.427563 0.903986 0 140.253 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.382676 -0.923883 0 -2.17701" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.923881 0.382681 0 2825.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.471409 0.881914 0 -2.16149" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.923881 0.382681 0 2825.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.903996 -0.427542 0 -0.259195" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.427542 0.903996 0 138.679 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="513" owner="0" type="0" pos="-17.915 101.232 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -17.915 0 1 0 101.232 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-1.33036 -1.7549 0.75" />
                            <Vertex pos="0.914631 1.99059 0.75" />
                            <Vertex pos="-0.889437 -1.99058 0.75" />
                            <Vertex pos="1.33036 1.71281 0.75" />
                            <Vertex pos="-1.33036 -1.7549 -0.75" />
                            <Vertex pos="0.914631 1.99059 -0.75" />
                            <Vertex pos="-0.889437 -1.99058 -0.75" />
                            <Vertex pos="1.33036 1.71281 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.4714 0.881919 0 139.189 0.857725 -0.514108 0 15.2877 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.471449 0.881892 -0.00165304 139.111 0.857237 -0.513816 0.0337294 16.8975 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.857725 0.514109 0 -0.238877" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.514108 0.857726 0 140.108 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.471395 -0.881922 0 -2.17481" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.88192 0.4714 0 2825.86 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.555564 0.831474 0 -2.16326" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.88192 0.4714 0 2825.86 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.857721 -0.514116 0 -0.260499" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.514114 0.857722 0 138.54 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="514" owner="0" type="0" pos="-15.5064 104.838 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -15.5064 0 1 0 104.838 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-1.49404 -1.61501 0.75" />
                            <Vertex pos="1.10747 1.89278 0.75" />
                            <Vertex pos="-1.07832 -1.89279 0.75" />
                            <Vertex pos="1.49404 1.57554 0.75" />
                            <Vertex pos="-1.49404 -1.61501 -0.75" />
                            <Vertex pos="1.10747 1.89278 -0.75" />
                            <Vertex pos="-1.07832 -1.89279 -0.75" />
                            <Vertex pos="1.49404 1.57554 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.555569 0.83147 0 139.065 0.803214 -0.59569 0 15.2302 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.555615 0.831438 -0.00165396 138.986 0.802757 -0.595351 0.0337275 16.8403 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.803214 0.595691 0 -0.237981" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.59569 0.803215 0 139.98 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.555575 -0.831466 0 -2.17288" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.83147 0.555569 0 2825.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.63439 0.773013 0 -2.16571" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.83147 0.555569 0 2825.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.803201 -0.595709 0 -0.261449" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.595709 0.8032 0 138.412 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="515" owner="0" type="0" pos="-12.7558 108.19 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -12.7558 0 1 0 108.19 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-1.64307 -1.45917 0.75" />
                            <Vertex pos="1.28952 1.77642 0.75" />
                            <Vertex pos="-1.25651 -1.77641 0.75" />
                            <Vertex pos="1.64307 1.42287 0.75" />
                            <Vertex pos="-1.64307 -1.45917 -0.75" />
                            <Vertex pos="1.28952 1.77642 -0.75" />
                            <Vertex pos="-1.25651 -1.77641 -0.75" />
                            <Vertex pos="1.64307 1.42287 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.634395 0.773009 0 138.9 0.740948 -0.671562 0 15.2011 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.634438 0.772972 -0.0016537 138.822 0.740527 -0.67118 0.0337312 16.8114 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.740948 0.671562 0 -0.237511" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.671562 0.740948 0 139.815 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.634398 -0.773007 0 -2.17031" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.773009 0.634395 0 2825.96 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.707098 0.707115 0 -2.16795" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.773009 0.634395 0 2825.96 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.74096 -0.671549 0 -0.261922" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.671549 0.74096 0 138.241 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="516" owner="0" type="0" pos="-9.68975 111.256 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -9.68975 0 1 0 111.256 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-1.77654 -1.28968 0.75" />
                            <Vertex pos="1.45936 1.64322 0.75" />
                            <Vertex pos="-1.42301 -1.64322 0.75" />
                            <Vertex pos="1.77654 1.25673 0.75" />
                            <Vertex pos="-1.77654 -1.28968 -0.75" />
                            <Vertex pos="1.45936 1.64322 -0.75" />
                            <Vertex pos="-1.42301 -1.64322 -0.75" />
                            <Vertex pos="1.77654 1.25673 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.707106 0.707108 0 138.762 0.671566 -0.740945 0 15.1989 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.707144 0.707067 -0.00165326 138.683 0.671184 -0.740523 0.0337298 16.8095 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.671566 0.740945 0 -0.237481" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.740946 0.671564 0 139.675 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.707112 -0.707102 0 -2.16815" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.707108 0.707106 0 2825.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.773012 0.634391 0 -2.17054" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.707108 0.707106 0 2825.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.671565 -0.740946 0 -0.261894" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.740946 0.671564 0 138.101 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="517" owner="0" type="0" pos="-6.33776 114.007 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.33776 0 1 0 114.007 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2159">
                        <Vertices>
                            <Vertex pos="-1.89265 -1.10739 0.75" />
                            <Vertex pos="1.61486 1.49391 0.75" />
                            <Vertex pos="-1.57544 -1.49391 0.75" />
                            <Vertex pos="1.89265 1.07819 0.75" />
                            <Vertex pos="-1.89265 -1.10739 -0.75" />
                            <Vertex pos="1.61486 1.49391 -0.75" />
                            <Vertex pos="-1.57544 -1.49391 -0.75" />
                            <Vertex pos="1.89265 1.07819 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.773013 0.63439 0 138.596 0.595693 -0.803212 0 15.2291 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.773047 0.634346 -0.00165395 138.518 0.595355 -0.802755 0.0337275 16.8395 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="-0.595693 0.803212 0 -0.237968" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.803212 0.595694 0 139.511 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.77301 -0.634394 0 -2.16556" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.63439 0.773013 0 2825.95 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.831458 0.555588 0 -2.17269" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.63439 0.773013 0 2825.95 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="0.595697 -0.803209 0 -0.261438" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.80321 0.595696 0 137.941 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="518" owner="0" type="0" pos="46.3378 114.006 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 46.3378 0 1 0 114.006 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2159">
                        <Vertices>
                            <Vertex pos="-1.61481 1.4939 0.75" />
                            <Vertex pos="1.89259 -1.1074 0.75" />
                            <Vertex pos="-1.89259 1.07819 0.75" />
                            <Vertex pos="1.57539 -1.4939 0.75" />
                            <Vertex pos="-1.61481 1.4939 -0.75" />
                            <Vertex pos="1.89259 -1.1074 -0.75" />
                            <Vertex pos="-1.89259 1.07819 -0.75" />
                            <Vertex pos="1.57539 -1.4939 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.831468 -0.555573 0 139.049 -0.595705 -0.803203 0 15.2291 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.831436 -0.555619 -0.00165538 138.971 -0.595366 -0.802746 0.0337287 16.8398 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.595704 0.803204 0 -0.237953" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.803203 -0.595705 0 139.965 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.831463 0.55558 0 -2.17264" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.555573 0.831468 0 2825.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.773009 -0.634395 0 -2.16551" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.555573 0.831468 0 2825.92 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.595708 -0.803201 0 -0.261423" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.803201 -0.595708 0 138.397 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="519" owner="0" type="0" pos="49.6898 111.256 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 49.6898 0 1 0 111.256 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-1.45935 1.64317 0.75" />
                            <Vertex pos="1.77654 -1.28963 0.75" />
                            <Vertex pos="-1.77654 1.25668 0.75" />
                            <Vertex pos="1.423 -1.64317 0.75" />
                            <Vertex pos="-1.45935 1.64317 -0.75" />
                            <Vertex pos="1.77654 -1.28963 -0.75" />
                            <Vertex pos="-1.77654 1.25668 -0.75" />
                            <Vertex pos="1.423 -1.64317 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.773012 -0.634392 0 138.913 -0.671553 -0.740957 0 15.1989 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.772976 -0.634434 -0.00165239 138.834 -0.671171 -0.740535 0.0337299 16.809 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.671554 0.740956 0 -0.237484" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.740956 -0.671553 0 139.827 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.77302 0.634382 0 -2.17051" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.634392 0.773012 0 2825.96 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.707114 -0.707099 0 -2.16811" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.634392 0.773012 0 2825.96 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.671554 -0.740956 0 -0.261898" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.740956 -0.671553 0 138.257 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="520" owner="0" type="0" pos="52.7558 108.19 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 52.7558 0 1 0 108.19 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-1.28954 1.77639 0.75" />
                            <Vertex pos="1.64306 -1.45921 0.75" />
                            <Vertex pos="-1.64307 1.42285 0.75" />
                            <Vertex pos="1.25657 -1.77639 0.75" />
                            <Vertex pos="-1.28954 1.77639 -0.75" />
                            <Vertex pos="1.64306 -1.45921 -0.75" />
                            <Vertex pos="-1.64307 1.42285 -0.75" />
                            <Vertex pos="1.25657 -1.77639 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.707106 -0.707108 0 138.748 -0.740948 -0.671562 0 15.1992 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.707065 -0.707146 -0.00165315 138.669 -0.740527 -0.67118 0.0337298 16.8093 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.740948 0.671562 0 -0.237477" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.67156 -0.74095 0 139.662 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.707114 0.707099 0 -2.16793" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.707108 0.707106 0 2825.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.63439 -0.773013 0 -2.17033" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.707108 0.707106 0 2825.97 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.74095 -0.67156 0 -0.261899" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.67156 -0.74095 0 138.087 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="521" owner="0" type="0" pos="55.5064 104.838 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 55.5064 0 1 0 104.838 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-1.10755 1.89281 0.75" />
                            <Vertex pos="1.49404 -1.61498 0.75" />
                            <Vertex pos="-1.49404 1.57562 0.75" />
                            <Vertex pos="1.07827 -1.8928 0.75" />
                            <Vertex pos="-1.10755 1.89281 -0.75" />
                            <Vertex pos="1.49404 -1.61498 -0.75" />
                            <Vertex pos="-1.49404 1.57562 -0.75" />
                            <Vertex pos="1.07827 -1.8928 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.634395 -0.773009 0 138.609 -0.803203 -0.595705 0 15.2301 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.634351 -0.773043 -0.00165269 138.531 -0.802746 -0.595366 0.0337286 16.8404 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.803204 0.595704 0 -0.237967" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.595705 -0.803203 0 139.525 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.63439 0.773013 0 -2.16578" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.773009 0.634395 0 2825.94 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.55558 -0.831463 0 -2.17286" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.773009 0.634395 0 2825.94 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.803213 -0.595693 0 -0.261446" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.595694 -0.803212 0 137.954 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="522" owner="0" type="0" pos="57.9151 101.232 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 57.9151 0 1 0 101.232 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.914616 1.99066 0.75" />
                            <Vertex pos="1.33039 -1.75496 0.75" />
                            <Vertex pos="-1.33038 1.71284 0.75" />
                            <Vertex pos="0.889408 -1.99066 0.75" />
                            <Vertex pos="-0.914616 1.99066 -0.75" />
                            <Vertex pos="1.33039 -1.75496 -0.75" />
                            <Vertex pos="-1.33038 1.71284 -0.75" />
                            <Vertex pos="0.889408 -1.99066 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.555568 -0.831471 0 138.45 -0.857731 -0.514098 0 15.2904 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.555521 -0.831501 -0.00165491 138.371 -0.857243 -0.513806 0.0337294 16.9004 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.857732 0.514097 0 -0.238897" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.514099 -0.857731 0 139.368 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.555594 0.831454 0 -2.1633" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.831471 0.555568 0 2825.89 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.471388 -0.881926 0 -2.17487" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.831471 0.555568 0 2825.89 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.857729 -0.514103 0 -0.260534" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.514105 -0.857727 0 137.799 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="523" owner="0" type="0" pos="59.9586 97.4076 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 59.9586 0 1 0 97.4076 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.713112 2.06963 0.75" />
                            <Vertex pos="1.15409 -1.87828 0.75" />
                            <Vertex pos="-1.15409 1.83392 0.75" />
                            <Vertex pos="0.692169 -2.06962 0.75" />
                            <Vertex pos="-0.713112 2.06963 -0.75" />
                            <Vertex pos="1.15409 -1.87828 -0.75" />
                            <Vertex pos="-1.15409 1.83392 -0.75" />
                            <Vertex pos="0.692169 -2.06962 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.471397 -0.881921 0 138.329 -0.903991 -0.427552 0 15.3739 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.471348 -0.881946 -0.00165294 138.251 -0.903476 -0.427309 0.0337282 16.9843 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.903991 0.427552 0 -0.240225" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.427553 -0.903991 0 139.251 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.471385 0.881928 0 -2.16141" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.881921 0.471397 0 2825.81 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.382689 -0.923877 0 -2.17696" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.881921 0.471397 0 2825.81 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.903987 -0.42756 0 -0.259174" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.42756 -0.903987 0 137.682 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="524" owner="0" type="0" pos="61.6173 93.401 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 61.6173 0 1 0 93.401 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.504585 2.12836 0.75" />
                            <Vertex pos="0.966511 -1.98324 0.75" />
                            <Vertex pos="-0.966515 1.93702 0.75" />
                            <Vertex pos="0.488121 -2.12836 0.75" />
                            <Vertex pos="-0.504585 2.12836 -0.75" />
                            <Vertex pos="0.966511 -1.98324 -0.75" />
                            <Vertex pos="-0.966515 1.93702 -0.75" />
                            <Vertex pos="0.488121 -2.12836 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.382681 -0.923881 0 138.204 -0.941548 -0.336879 0 15.4813 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.382629 -0.923901 -0.00165452 138.126 -0.941012 -0.336687 0.0337289 17.0912 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.941548 0.336878 0 -0.241907" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.33688 -0.941548 0 139.131 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.382697 0.923874 0 -2.15944" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.923881 0.382681 0 2825.71 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.290286 -0.95694 0 -2.1784" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.923881 0.382681 0 2825.71 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.941543 -0.336894 0 -0.257444" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.336893 -0.941543 0 137.557 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="525" owner="0" type="0" pos="62.8752 89.2507 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 62.8752 0 1 0 89.2507 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.291389 2.16696 0.75" />
                            <Vertex pos="0.76981 -2.0694 0.75" />
                            <Vertex pos="-0.76981 2.02184 0.75" />
                            <Vertex pos="0.279381 -2.16696 0.75" />
                            <Vertex pos="-0.291389 2.16696 -0.75" />
                            <Vertex pos="0.76981 -2.0694 -0.75" />
                            <Vertex pos="-0.76981 2.02184 -0.75" />
                            <Vertex pos="0.279381 -2.16696 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.290286 -0.95694 0 138.127 -0.970029 -0.24299 0 15.6083 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.290232 -0.956955 -0.0016539 138.049 -0.969477 -0.242851 0.0337308 17.2182 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.970029 0.24299 0 -0.243893" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.24299 -0.970029 0 139.06 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.290269 0.956945 0 -2.15824" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.95694 0.290286 0 2825.59 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.195099 -0.980784 0 -2.17983" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.95694 0.290286 0 2825.59 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.970034 -0.242969 0 -0.255496" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.242971 -0.970034 0 137.492 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="526" owner="0" type="0" pos="63.7201 84.9971 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 63.7201 0 1 0 84.9971 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="-0.0751572 2.18427 0.75" />
                            <Vertex pos="0.565552 -2.13525 0.75" />
                            <Vertex pos="-0.565548 2.08674 0.75" />
                            <Vertex pos="0.067955 -2.18427 0.75" />
                            <Vertex pos="-0.0751572 2.18427 -0.75" />
                            <Vertex pos="0.565552 -2.13525 -0.75" />
                            <Vertex pos="-0.565548 2.08674 -0.75" />
                            <Vertex pos="0.067955 -2.18427 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.195086 -0.980786 0 138.046 -0.989178 -0.146721 0 15.7536 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.195031 -0.980796 -0.00165441 137.967 -0.988615 -0.146638 0.0337304 17.3634 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.989178 0.146723 0 -0.24614" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.146721 -0.989178 0 138.986 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.19507 0.980789 0 -2.15697" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.980786 0.195086 0 2825.45 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0.0980367 -0.995183 0 -2.18041" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.980786 0.195086 0 2825.45 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.989178 -0.146721 0 -0.253259" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.146721 -0.989178 0 137.416 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="527" owner="0" type="0" pos="64.1441 80.6809 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 64.1441 0 1 0 80.6809 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1621" nextVertexID="2161">
                        <Vertices>
                            <Vertex pos="0.141663 2.1809 0.75" />
                            <Vertex pos="0.355957 -2.18089 0.75" />
                            <Vertex pos="-0.355957 2.1319 0.75" />
                            <Vertex pos="-0.144058 -2.18089 0.75" />
                            <Vertex pos="0.141663 2.1809 -0.75" />
                            <Vertex pos="0.355957 -2.18089 -0.75" />
                            <Vertex pos="-0.355957 2.1319 -0.75" />
                            <Vertex pos="-0.144058 -2.18089 -0.75" />
                        </Vertices>
                        <Face id="1614" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.0980178 -0.995185 0 138.017 -0.998795 -0.0490716 0 15.9039 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1615" plane="0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.0979622 -0.995189 -0.00165406 137.938 -0.998227 -0.0490437 0.0337306 17.5143 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1616" plane="0.998795 0.0490707 0 -0.24851" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.0490718 -0.998795 0 138.964 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1617" plane="-0.098002 0.995186 0 -2.15652" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.995185 0.0980178 0 2825.3 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1618" plane="0 -1 0 -2.18089" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.995185 0.0980178 0 2825.3 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1619" plane="-0.998795 -0.0490735 0 -0.250909" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.0490737 -0.998795 0 137.394 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="540" owner="0" type="0" pos="-2.73208 116.415 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.73208 0 1 0 116.415 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-1.99081 -0.914742 0.75" />
                            <Vertex pos="1.75509 1.33046 0.75" />
                            <Vertex pos="-1.71303 -1.33046 0.75" />
                            <Vertex pos="1.99081 0.889458 0.75" />
                            <Vertex pos="-1.99081 -0.914742 -0.75" />
                            <Vertex pos="1.75509 1.33046 -0.75" />
                            <Vertex pos="-1.71303 -1.33046 -0.75" />
                            <Vertex pos="1.99081 0.889458 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.831469 0.555571 0 138.465 0.514102 -0.857729 0 15.2877 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.831499 0.555523 -0.00165502 138.386 0.513809 -0.857241 0.0337294 16.8982 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="-0.514102 0.857729 0 -0.238878" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.85773 0.5141 0 139.383 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.831466 -0.555576 0 -2.1635" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.555571 0.831469 0 2825.89 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.881925 0.47139 0 -2.17503" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.555571 0.831469 0 2825.89 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="0.514089 -0.857737 0 -0.260533" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.857736 0.51409 0 137.81 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="541" owner="0" type="0" pos="1.09246 118.459 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 1.09246 0 1 0 118.459 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-2.06946 -0.713005 0.75" />
                            <Vertex pos="1.87813 1.15399 0.75" />
                            <Vertex pos="-1.83374 -1.15399 0.75" />
                            <Vertex pos="2.06946 0.692101 0.75" />
                            <Vertex pos="-2.06946 -0.713005 -0.75" />
                            <Vertex pos="1.87813 1.15399 -0.75" />
                            <Vertex pos="-1.83374 -1.15399 -0.75" />
                            <Vertex pos="2.06946 0.692101 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.881923 0.471393 0 138.318 0.42754 -0.903996 0 15.3739 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.881948 0.471343 -0.00165446 138.239 0.427297 -0.903482 0.0337274 16.9842 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="-0.427541 0.903996 0 -0.240224" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.903996 0.42754 0 139.24 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.881918 -0.471403 0 -2.1612" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.471393 0.881923 0 2825.81 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.923879 0.382686 0 -2.17678" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.471393 0.881923 0 2825.81 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="0.427558 -0.903988 0 -0.259163" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.903987 0.427559 0 137.671 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="542" owner="0" type="0" pos="5.09893 120.117 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 5.09893 0 1 0 120.117 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-2.12833 -0.504662 0.75" />
                            <Vertex pos="1.98318 0.966537 0.75" />
                            <Vertex pos="-1.93701 -0.966537 0.75" />
                            <Vertex pos="2.12833 0.488029 0.75" />
                            <Vertex pos="-2.12833 -0.504662 -0.75" />
                            <Vertex pos="1.98318 0.966537 -0.75" />
                            <Vertex pos="-1.93701 -0.966537 -0.75" />
                            <Vertex pos="2.12833 0.488029 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.92388 0.382684 0 138.205 0.336907 -0.941538 0 15.4802 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.9239 0.382632 -0.00165285 138.126 0.336715 -0.941002 0.0337295 17.0902 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="-0.336906 0.941538 0 -0.241889" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.941538 0.336906 0 139.131 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.923874 -0.382698 0 -2.15944" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.382684 0.92388 0 2825.71 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.956939 0.290289 0 -2.17835" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.382684 0.92388 0 2825.71 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="0.336883 -0.941547 0 -0.257496" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.941546 0.336885 0 137.563 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="543" owner="0" type="0" pos="9.24907 121.375 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 9.24907 0 1 0 121.375 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-2.16697 -0.291336 0.75" />
                            <Vertex pos="2.06943 0.769852 0.75" />
                            <Vertex pos="-2.02182 -0.769844 0.75" />
                            <Vertex pos="2.16697 0.279472 0.75" />
                            <Vertex pos="-2.16697 -0.291336 -0.75" />
                            <Vertex pos="2.06943 0.769852 -0.75" />
                            <Vertex pos="-2.02182 -0.769844 -0.75" />
                            <Vertex pos="2.16697 0.279472 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.956939 0.29029 0 138.127 0.242988 -0.970029 0 15.6121 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.956954 0.290236 -0.00165404 138.049 0.24285 -0.969477 0.0337308 17.2228 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="-0.242985 0.97003 0 -0.243938" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.970029 0.242988 0 139.06 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.95694 -0.290284 0 -2.15823" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.29029 0.956939 0 2825.58 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.980786 0.195089 0 -2.17986" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.29029 0.956939 0 2825.58 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="0.242997 -0.970027 0 -0.255473" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.970027 0.242996 0 137.488 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="544" owner="0" type="0" pos="13.5028 122.22 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 13.5028 0 1 0 122.22 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-2.18429 -0.0751495 0.75" />
                            <Vertex pos="2.13527 0.565552 0.75" />
                            <Vertex pos="-2.08674 -0.565552 0.75" />
                            <Vertex pos="2.18429 0.0679474 0.75" />
                            <Vertex pos="-2.18429 -0.0751495 -0.75" />
                            <Vertex pos="2.13527 0.565552 -0.75" />
                            <Vertex pos="-2.08674 -0.565552 -0.75" />
                            <Vertex pos="2.18429 0.0679474 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.980785 0.19509 0 138.047 0.14672 -0.989178 0 15.7534 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="0 -0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.980795 0.195035 -0.00165454 137.968 0.146637 -0.988615 0.0337304 17.3631 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="-0.14672 0.989178 0 -0.246143" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.989178 0.14672 0 138.987 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.980786 -0.195089 0 -2.15698" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.19509 0.980785 0 2825.45 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.995184 0.098022 0 -2.18043" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.19509 0.980785 0 2825.45 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="0.14672 -0.989178 0 -0.253266" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.989178 0.146721 0 137.417 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="545" owner="0" type="0" pos="17.8191 122.644 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 17.8191 0 1 0 122.644 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-2.18099 0.141647 0.75" />
                            <Vertex pos="2.18099 0.355949 0.75" />
                            <Vertex pos="-2.13198 -0.355949 0.75" />
                            <Vertex pos="2.18099 -0.144051 0.75" />
                            <Vertex pos="-2.18099 0.141647 -0.75" />
                            <Vertex pos="2.18099 0.355949 -0.75" />
                            <Vertex pos="-2.13198 -0.355949 -0.75" />
                            <Vertex pos="2.18099 -0.144051 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="0 -0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.995184 0.0980211 0 138.023 0.0490695 -0.998795 0 15.9049 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.995188 0.0979655 -0.00165418 137.945 0.0490415 -0.998227 0.0337306 17.5151 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="-0.0490704 0.998795 0 -0.248499" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.998795 0.0490694 0 138.971 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.995184 -0.0980197 0 -2.1566" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.0980211 0.995184 0 2825.3 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="1 -3.8147e-006 0 -2.18099" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 -0.0980211 0.995184 0 2825.3 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="0.0490715 -0.998795 0 -0.250901" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.998795 0.0490713 0 137.401 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="546" owner="0" type="0" pos="22.1808 122.644 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 22.1808 0 1 0 122.644 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-2.18079 0.355949 0.75" />
                            <Vertex pos="2.18078 0.141663 0.75" />
                            <Vertex pos="-2.18079 -0.144066 0.75" />
                            <Vertex pos="2.13177 -0.355949 0.75" />
                            <Vertex pos="-2.18079 0.355949 -0.75" />
                            <Vertex pos="2.18078 0.141663 -0.75" />
                            <Vertex pos="-2.18079 -0.144066 -0.75" />
                            <Vertex pos="2.13177 -0.355949 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="1 0 0 139.57 -0.0490741 -0.998795 0 15.9035 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.999999 0 -0.00165426 139.492 -0.0490462 -0.998227 0.0337306 17.5136 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="0.0490715 0.998795 0 -0.248506" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.998795 -0.0490742 0 140.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-1 0 0 -2.18079" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0 1 0 2825.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.995185 -0.0980148 0 -2.1564" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0 1 0 2825.22 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="-0.0490725 -0.998795 0 -0.250909" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.998795 -0.0490761 0 138.95 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="547" owner="0" type="0" pos="26.4971 122.22 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 26.4971 0 1 0 122.22 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-2.13549 0.565605 0.75" />
                            <Vertex pos="2.18449 -0.0751953 0.75" />
                            <Vertex pos="-2.18449 0.0679932 0.75" />
                            <Vertex pos="2.08695 -0.565613 0.75" />
                            <Vertex pos="-2.13549 0.565605 -0.75" />
                            <Vertex pos="2.18449 -0.0751953 -0.75" />
                            <Vertex pos="-2.18449 0.0679932 -0.75" />
                            <Vertex pos="2.08695 -0.565613 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.995185 -0.0980138 0 139.561 -0.146729 -0.989177 0 15.7517 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.995178 -0.0980691 -0.00165382 139.483 -0.146645 -0.988614 0.0337304 17.362 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="0.146729 0.989177 0 -0.246146" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.989177 -0.146728 0 140.503 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.995185 0.098011 0 -2.18064" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.0980138 0.995185 0 2825.37 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.980787 -0.195082 0 -2.15719" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.0980138 0.995185 0 2825.37 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="-0.14673 -0.989177 0 -0.253273" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.989177 -0.146729 0 138.933 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="548" owner="0" type="0" pos="30.7508 121.375 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 30.7508 0 1 0 121.375 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-2.06918 0.769745 0.75" />
                            <Vertex pos="2.16673 -0.291267 0.75" />
                            <Vertex pos="-2.16673 0.27935 0.75" />
                            <Vertex pos="2.02158 -0.769737 0.75" />
                            <Vertex pos="-2.06918 0.769745 -0.75" />
                            <Vertex pos="2.16673 -0.291267 -0.75" />
                            <Vertex pos="-2.16673 0.27935 -0.75" />
                            <Vertex pos="2.02158 -0.769737 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.980785 -0.195092 0 139.494 -0.242972 -0.970033 0 15.612 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.980773 -0.195146 -0.00165345 139.416 -0.242833 -0.969481 0.0337306 17.2219 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="0.242974 0.970033 0 -0.24392" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.970033 -0.242972 0 140.429 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.980785 0.19509 0 -2.17959" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.195092 0.980785 0 2825.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.956941 -0.290284 0 -2.15798" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.195092 0.980785 0 2825.52 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="-0.242974 -0.970033 0 -0.255479" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.970033 -0.242974 0 138.859 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="549" owner="0" type="0" pos="34.9009 120.117 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 34.9009 0 1 0 120.117 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-1.98343 0.966591 0.75" />
                            <Vertex pos="2.12857 -0.504715 0.75" />
                            <Vertex pos="-2.12857 0.488106 0.75" />
                            <Vertex pos="1.93724 -0.966599 0.75" />
                            <Vertex pos="-1.98343 0.966591 -0.75" />
                            <Vertex pos="2.12857 -0.504715 -0.75" />
                            <Vertex pos="-2.12857 0.488106 -0.75" />
                            <Vertex pos="1.93724 -0.966599 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.956941 -0.290281 0 139.431 -0.336891 -0.941544 0 15.4813 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.956924 -0.290334 -0.00165455 139.352 -0.336699 -0.941008 0.0337292 17.0911 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="0.336892 0.941543 0 -0.241887" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.941544 -0.336891 0 140.359 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.956941 0.290282 0 -2.1786" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.290281 0.956942 0 2825.65 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.923877 -0.38269 0 -2.15968" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.290281 0.956942 0 2825.65 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="-0.336876 -0.941549 0 -0.257489" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.941549 -0.336876 0 138.786 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="550" owner="0" type="0" pos="38.9076 118.459 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 38.9076 0 1 0 118.459 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-1.87809 1.154 0.75" />
                            <Vertex pos="2.06941 -0.71299 0.75" />
                            <Vertex pos="-2.06941 0.692108 0.75" />
                            <Vertex pos="1.83369 -1.154 0.75" />
                            <Vertex pos="-1.87809 1.154 -0.75" />
                            <Vertex pos="2.06941 -0.71299 -0.75" />
                            <Vertex pos="-2.06941 0.692108 -0.75" />
                            <Vertex pos="1.83369 -1.154 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.923879 -0.382685 0 139.312 -0.427549 -0.903992 0 15.3749 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.923856 -0.382736 -0.00165506 139.233 -0.427306 -0.903478 0.0337281 16.9848 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="0.427547 0.903993 0 -0.240234" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.903992 -0.427549 0 140.235 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.923882 0.382678 0 -2.17675" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.382685 0.923879 0 2825.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.881927 -0.471386 0 -2.16116" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.382685 0.923879 0 2825.76 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="-0.427569 -0.903982 0 -0.259164" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.903983 -0.427568 0 138.663 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="551" owner="0" type="0" pos="42.7321 116.415 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 42.7321 0 1 0 116.415 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="1615" nextVertexID="2153">
                        <Vertices>
                            <Vertex pos="-1.75514 1.33051 0.75" />
                            <Vertex pos="1.99086 -0.914795 0.75" />
                            <Vertex pos="-1.99086 0.889511 0.75" />
                            <Vertex pos="1.71309 -1.33051 0.75" />
                            <Vertex pos="-1.75514 1.33051 -0.75" />
                            <Vertex pos="1.99086 -0.914795 -0.75" />
                            <Vertex pos="-1.99086 0.889511 -0.75" />
                            <Vertex pos="1.71309 -1.33051 -0.75" />
                        </Vertices>
                        <Face id="1608" plane="-0 0 1 -0.75" album="PQ" material="pq_wood_2" texgens="0.881923 -0.471393 0 139.206 -0.514108 -0.857725 0 15.2885 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1609" plane="-0 0 -1 -0.75" album="PQ" material="pq_wood_2" texgens="0.881896 -0.471442 -0.00165331 139.128 -0.513816 -0.857237 0.0337294 16.8985 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1610" plane="0.51411 0.857725 0 -0.238878" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.857724 -0.514109 0 140.125 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1611" plane="-0.881927 0.471387 0 -2.17509" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.471393 0.881923 0 2825.85 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1612" plane="0.831472 -0.555566 0 -2.16357" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.471393 0.881923 0 2825.85 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1613" plane="-0.514097 -0.857732 0 -0.26053" album="PQ" material="pq_wood_2" texgens="0 0 -1 48 0.857732 -0.514098 0 138.554 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
