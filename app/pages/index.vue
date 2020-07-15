<template>
  <div>
    <PageTitle/>
    <section class="section-padding">
      <div class="flex -mx-2 flex-wrap mt-6">
        <MovieCategories v-for="(quizCategory,index) in quizCategories" :key="index" :quizCategory='quizCategory' />
      </div>
    </section>
  </div>
</template>

<script>
import MovieCategories from '@/components/MovieCategory'
import PageTitle from '@/components/UI/pageTitle'
export default {
  components: {
    MovieCategories,
    PageTitle
  },
  data() {
    return {
      quizCategories: [
        {
          category: 'Movies',
          category_image: 'https://tailwindcss.com/img/card-top.jpg',
          description: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque',
          subCategories: ['Hollywood', 'Nollywood', 'Series']
        },
        {
          category: 'Sports',
          category_image: 'https://images.unsplash.com/photo-1552667466-07770ae110d0?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1950&q=80',
          description: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque',
          subCategories: ['Football', 'Basketball', 'Tennis']
        },
        {
          category: 'Places',
          category_image: 'https://tailwindcss.com/img/card-top.jpg',
          description: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque',
          subCategories: ['Europe','South America', 'Asia', 'North America', 'Africa']
        },
        {
          category: 'Music',
          category_image: 'https://tailwindcss.com/img/card-top.jpg',
          description: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque',
          subCategories: ['Rock','Hip Hop', 'Blues', 'Country Music', 'R & B']
        }
      ]
    }
  },
}
</script>

<style>
</style>
