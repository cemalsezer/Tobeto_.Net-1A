import React from 'react'
import { ErrorMessage, Form, Formik } from 'formik'
import { Button,  Label } from 'semantic-ui-react'
import * as Yup from 'yup'
import KodlamaIoTextInput from '../utilities/customFormControls/KodlamaIoTextInput'

export default function ProductAdd() {
    const initialValues = {
        title:"",
        price:10
    }
    
    const schema=Yup.object({
        title : Yup.string().required("Ürün adı zorunlu"),
        price:Yup.number().required("Ürün fiyatı zorunlu")
})
  return (
    <div>
         <Formik
            initialValues={initialValues}
            validationSchema={schema}
            onSubmit={(values)=>{
                console.log(values);
            }}
            >
                <Form className='ui form'>
                    <KodlamaIoTextInput name="title" placeholder="Ürün Adı"/>
                    <KodlamaIoTextInput name="price" placeholder="Ürün Fiyatı"/>
                
                    <Button color='green' type='submit'>Ekle</Button>
                </Form>

        </Formik>
    </div>
  )
}
