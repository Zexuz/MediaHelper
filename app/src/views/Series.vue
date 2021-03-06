<template>
  <div class="container">
    <img class="bg" :src="backgroundImage" alt="backgorund image" />
    <div class="row">
      <div class="col s12">
        <div class="card blue-grey darken-1 opacity">
          <div class="card-content white-text">
            <span class="card-title">{{ currentSeries.title }}</span>
            <img class="left" height="200px" :src="imageUrl" />
            <p>
              {{ currentSeries.overview }}
            </p>

            <h5>Next episode placeholder!</h5>
            <p>
              NEXT EPISODE OVERVIEW PLACEHOLDER
            </p>
          </div>
          <div class="card-action">
            <button class="btn">Play</button>
            <a
              class="right"
              target="_blank"
              href="http://192.168.10.240:8989/series/doom-patrol"
              >Go to Sonarr</a
            >
          </div>
        </div>
      </div>
    </div>
    <div>
      <ul class="collapsible popout opacity">
        <li v-for="season in seasons" :key="season.number">
          <div class="collapsible-header">
            <span>Season {{ season.number }}</span>
          </div>
          <div class="collapsible-body">
            <table class="series-table">
              <thead>
                <tr>
                  <th class="episode-nr">#</th>
                  <th class="play"></th>
                  <th>Name</th>
                  <th>Progress</th>
                  <th>Download date</th>
                  <th class="option"></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for="episode in season.episodes">
                  <td>{{ episode.episideNumber }}</td>
                  <td>
                    <button
                      :disabled="episode.playableId === ''"
                      @click="play(episode)"
                      class="btn"
                    >
                      play
                    </button>
                  </td>
                  <td>
                    {{ episode.title }}
                  </td>
                  <td>
                    <div class="progress">
                      <div
                        class="determinate"
                        :style="`width: ${getTotalDuration(episode)}%`"
                      ></div>
                    </div>
                  </td>
                  <td>TODO</td>
                  <td>
                    <button
                      class="dropdown-trigger btn-floating btn btn-flat"
                      :data-target="episode.title"
                    >
                      <i class="material-icons dp48 black-text">more_vert</i>
                    </button>
                    <ul :id="episode.title" class="dropdown-content">
                      <li><a href="JavaScript:void(0);">Mark as seen</a></li>
                      <li>
                        <a
                          @click="download(episode.playableId)"
                          href="JavaScript:void(0);"
                          >Download</a
                        >
                      </li>
                    </ul>
                  </td>
                </tr>
              </tbody>
            </table>
          </div>
        </li>
      </ul>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { Action, Getter, State } from "vuex-class";
import { Module } from "@/store/store";
import { SeriesState } from "@/store/modules/series/types";
import { Episode, ImageUrl, Series } from "@/logic/api/types";
import { ActionTypes } from "@/store/modules/episodes/actions";
import { Methods, Season } from "@/store/modules/episodes/getters";
import M from "materialize-css";
import { HttpClient } from "@/logic/http/httpClient";
import { Endpoints as RemoteEndpoints } from "@/logic/api/remote/endpoints";
import { Endpoints as FileEndpoints } from "@/logic/api/file/endpoints";

@Component({
  components: {}
})
export default class SeriesInfo extends Vue {
  @State(Module.SERIES)
  private seriesState!: SeriesState;

  @Action(ActionTypes.FETCH_EPISODES, { namespace: Module.EPISODES })
  private fetchEpisodes!: (seriesId: number) => Promise<void>;

  @Getter(Methods.GET_SEASONS, { namespace: Module.EPISODES })
  private getSeasons!: (seriesId: number) => Season[];

  async mounted() {
    await this.fetchEpisodes(this.currentId());
    M.AutoInit();
  }

  private async play(episode: Episode) {
    let startPos =
      episode.progress && episode.progress.watchedInSec
        ? episode.progress.watchedInSec
        : 0;
    await HttpClient.get<object>(
      RemoteEndpoints.PlayFileOnStartPosition(episode.playableId, startPos)
    );
  }

  get imageUrl(): string {
    if (!this.currentSeries.imagesUrl || !this.currentSeries.imagesUrl.poster) {
      return "SomePathToStandarBanner";
    }

    return `http://192.168.10.240:8989${this.currentSeries.imagesUrl.poster}`; //todo change this to banner?
  }

  get backgroundImage(): string {
    if (!this.currentSeries.imagesUrl || !this.currentSeries.imagesUrl.poster) {
      return "SomePathToStandarBanner";
    }

    return `http://192.168.10.240:8989${this.currentSeries.imagesUrl.fanart}`; //todo change this to banner?
  }

  get currentSeries(): Series {
    let id = this.currentId();
    let matches = this.seriesState.series.filter(value => value.id === id);
    if (matches.length == 0) {
      return new Series({ imagesUrl: new ImageUrl() });
    }
    return matches[0];
  }

  get seasons(): Season[] {
    return this.getSeasons(this.currentId());
  }

  private currentId(): number {
    return Number(this.$route.params["id"]);
  }

  private async downloadedFiles(): Promise<void> {
    let res = await HttpClient.get<string[]>(
      FileEndpoints.GetDownloadedFiles()
    );
  }

  private getTotalDuration(episode: Episode): number {
    if (
      !episode.progress ||
      !episode.progress.watchedInSec ||
      !episode.progress.lenght
    )
      return 0;

    return (episode.progress.watchedInSec / episode.progress.lenght) * 100;
  }
}
</script>

<style scoped>
.option {
  width: 2rem;
}

.play {
  width: 6rem;
}

.episode-nr {
  width: 4rem;
}

img.bg {
  min-height: 100%;
  min-width: 1080px;
  width: 100%;
  height: auto;
  position: fixed;
  top: 0;
  left: 0;
  z-index: -100000;
}

td {
  padding-top: 2px;
  padding-bottom: 2px;
}

img.left {
  margin-right: 25px;
}

.collapsible-body {
  background-color: white;
}

.card-content {
  overflow: hidden;
}

.opacity {
  opacity: 0.9;
}
</style>
