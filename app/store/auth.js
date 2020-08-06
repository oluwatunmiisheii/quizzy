import Vuex from "vuex";

export const state = () => ({
  formState: 'Sign In'
})


export const mutations = {
  setAuthFormState(state, formState) {
    state.formState = formState
  }
};

export const actions = {
  getAuthFormState({ commit }, formState) {
    commit('setAuthFormState', formState)
  }
};
export const getters = {

};
