import React from 'react'
import { ErrorMessage, Field, useField } from 'formik'
import { FormField, Label } from 'semantic-ui-react';

export default function KodlamaIoTextInput(props) {
    const [field,meta]=useField(props);
  return (
    <FormField error={!!meta.error}>
                    <Label>Ürün Adı</Label>
                    <Field {...field}{...props}></Field>
                    <ErrorMessage name={field.name} render={error=>
                        <Label pointing basic color='red' content={error}/>
                    }/>
                </FormField>
  )
}