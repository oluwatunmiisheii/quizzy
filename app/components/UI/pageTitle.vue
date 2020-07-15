<template>
  <div class="flex flex-shrink-0 flex-wrap justify-between pt-20 items-center">
    <div>
      <h4 class="text-3xl md:text-4xl">Welcome <span class="emoji wave-hand animated"></span></h4>
      <p>Select a category to get started</p>
    </div>
    <div>
      <h4>hello</h4>
    </div>
  </div>
</template>

<style>
  .wave-hand.animated {
    -webkit-animation-duration: 1s;
    animation-duration: 1s;
    -webkit-animation-fill-mode: both;
    animation-fill-mode: both;
  }

  .wave-hand {
    background-image: url('~assets/images/wave.png');
    margin-left: 10px;
    cursor: pointer;
  }

  .emoji {
    display: inline-block;
    vertical-align: text-top;
    background-size: contain;
    background-repeat: no-repeat;
    background-position: center;
    width: 40px;
    height: 40px;
  }

  .wave-hand:hover {
    -webkit-animation-name: wave;
    animation-name: wave
  }

  @-webkit-keyframes wave {
    from {
      -webkit-transform: none;
      transform: none
    }

    15% {
      -webkit-transform: translate3d(-20%, 0, 0) rotate3d(0, 0, 1, -10deg);
      transform: translate3d(-20%, 0, 0) rotate3d(0, 0, 1, -10deg)
    }

    30% {
      -webkit-transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 7deg);
      transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 7deg)
    }

    45% {
      -webkit-transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -10deg);
      transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -10deg)
    }

    60% {
      -webkit-transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 5deg);
      transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 5deg)
    }

    75% {
      -webkit-transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -2deg);
      transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -2deg)
    }

    to {
      -webkit-transform: none;
      transform: none
    }
  }

  @keyframes wave {
    from {
      -webkit-transform: none;
      transform: none
    }

    15% {
      -webkit-transform: translate3d(-20%, 0, 0) rotate3d(0, 0, 1, -10deg);
      transform: translate3d(-20%, 0, 0) rotate3d(0, 0, 1, -10deg)
    }

    30% {
      -webkit-transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 7deg);
      transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 7deg)
    }

    45% {
      -webkit-transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -10deg);
      transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -10deg)
    }

    60% {
      -webkit-transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 5deg);
      transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 5deg)
    }

    75% {
      -webkit-transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -2deg);
      transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -2deg)
    }

    to {
      -webkit-transform: none;
      transform: none
    }
  }

</style>
